function CalendarOptions(calendarElement) {

    var calendar = new FullCalendar.Calendar(calendarElement, {
        expandRows: true,
        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay,listWeek'
        },
        initialView: 'timeGridWeek',
        navLinks: true, // can click day/week names to navigate views
        editable: true,
        selectable: true,
        nowIndicator: true,
        dayMaxEvents: true, // allow "more" link when too many events
        eventResizableFromStart: true,
        slotEventOverlap: false,
        //   events: 'https://fullcalendar.io/api/demo-feeds/events.json',
        slotLabelFormat: {
            hour: '2-digit',
            minute: '2-digit',
            hour12: false
        },
        eventTimeFormat: {
            hour: '2-digit',
            minute: '2-digit',
            hour12: false
        },
        slotMinTime: '08:00:00',
        slotMaxTime: '17:30:00',
        slotLabelInterval: '00:30',
        events: [
            {
                title: 'Task Name',
                start: '2024-07-13T12:30:00',
                end: '2024-07-13T14:00:00',
                displayEventTime: true,
                description: 'Task Description',
                team: [
                    { initials: 'GG', name: 'Georgi Georgiev', color: 'blue' },
                    { initials: 'IG', name: 'Ivan Georgiev', color: 'blue' },
                    // Add more team members here
                ]
            },
            {
                title: 'Task Name',
                start: '2024-07-13T12:00:00',
                end: '2024-07-13T13:30:00',
                description: 'Task Description',
                team: [
                    { initials: 'GG', name: 'Georgi Georgiev', color: 'blue' },
                    { initials: 'GG', name: 'Georgi Georgiev', color: 'red' },
                    // Add more team members here
                ]
            }
        ],
        eventContent: function (arg) {
            var eventContent = document.createElement('div');
            eventContent.classList.add('event');

            var eventTitle = document.createElement('div');
            eventTitle.innerText = arg.event.title;
            eventTitle.classList.add('event-title');
            eventContent.appendChild(eventTitle);

            var eventTime = document.createElement('div');
            eventTime.innerText = arg.event.start.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' }) + ' - ' + arg.event.end.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' });
            eventTime.classList.add('event-time');
            eventContent.appendChild(eventTime);

            var eventDescription = document.createElement('div');
            eventDescription.innerText = arg.event.extendedProps.taskNumber + ' - ' + arg.event.extendedProps.comments;
            eventDescription.classList.add('event-description');
            eventContent.appendChild(eventDescription);

            var teamSection = document.createElement('div');
            teamSection.classList.add('team-section');

            // Display team members within the event card
            var teamData = arg.event.extendedProps.team;
            if (teamData) {
                teamData.forEach(function (member) {
                    var memberDiv = document.createElement('div');
                    memberDiv.classList.add('team-member');

                    var initialsDiv = document.createElement('div');
                    initialsDiv.innerText = member.initials;
                    initialsDiv.classList.add('member-initials');
                    initialsDiv.style.backgroundColor = member.color;
                    memberDiv.appendChild(initialsDiv);

                    var nameDiv = document.createElement('div');
                    nameDiv.innerText = member.name;
                    nameDiv.classList.add('member-name');
                    memberDiv.appendChild(nameDiv);

                    teamSection.appendChild(memberDiv);
                });
            }

            eventContent.appendChild(teamSection);

            // Highlight time slots only if arg.view.timeGrid is defined
            if (arg.view.timeGrid && arg.view.timeGrid.slots) {
                var eventStart = arg.event.start;
                var eventEnd = arg.event.end;
                if (eventStart.getHours() !== eventEnd.getHours()) {
                    var eventStartSlot = eventStart.getHours() + eventStart.getMinutes() / 60;
                    var eventEndSlot = eventEnd.getHours() + eventEnd.getMinutes() / 60;

                    for (var slot = eventStartSlot; slot < eventEndSlot; slot += 0.5) {
                        var slotEl = arg.view.timeGrid.slots.find(function (timeSlot) {
                            return timeSlot.date.getHours() + timeSlot.date.getMinutes() / 60 === slot;
                        });
                        if (slotEl) {
                            slotEl.el.style.background = 'lightblue'; // Set the background color as needed
                        }
                    }
                }
            }

            return { domNodes: [eventContent] };
        },
        eventClick: function (info) {
            var teamSection = info.el.querySelector('.team-section');
            if (teamSection) {
                // Toggle the visibility of the team section
                teamSection.classList.toggle('hidden');
            }
        }
    });
    calendar.render();


    // Create team member list with checkboxes
    var teamMembers = ['Georgi Georgiev', 'Ivan Georgiev']; // Update with your team members
    //var teamList = document.createElement('div');
    //teamList.classList.add('team-list');
    var teamList = document.querySelector('.team-players');
    teamMembers.forEach(function (member) {
        var memberDiv = document.createElement('div');
        memberDiv.classList.add('team-member');

        var initialsDiv = document.createElement('div');
        initialsDiv.innerText = member.split(' ').map(part => part[0]).join('');
        initialsDiv.classList.add('member-initials');
        initialsDiv.style.backgroundColor = 'blue'; // Set the color as needed
        memberDiv.appendChild(initialsDiv);

        var nameDiv = document.createElement('div');
        nameDiv.innerText = member;
        nameDiv.classList.add('member-name');
        memberDiv.appendChild(nameDiv);

        var checkbox = document.createElement('input');
        checkbox.type = 'checkbox';
        checkbox.checked = true;
        checkbox.classList.add('team-checkbox');
        checkbox.setAttribute('data-member', member);
        memberDiv.appendChild(checkbox);

        teamList.appendChild(memberDiv);
    });
  //  document.body.appendChild(teamList);

    // Add event listener to checkboxes
    document.querySelectorAll('.team-checkbox').forEach(function (checkbox) {
        checkbox.addEventListener('change', function () {
            var member = checkbox.getAttribute('data-member');
            var events = calendar.getEvents();
            events.forEach(function (event) {
                var team = event.extendedProps.team;
                if (team && team.some(memberObj => memberObj.name === member)) {
                    event.setProp('display', checkbox.checked ? 'block' : 'none');
                }
            });
        });
    });

    return calendar;
}

