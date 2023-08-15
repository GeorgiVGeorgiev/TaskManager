function generateQuickGuid(br) {
	return Math.random().toString(36).substring(2, br) +
		Math.random().toString(36).substring(2, br);
};

$(function () {
	$("button.GenerateDataForUser").click(function (e) {
		e.preventDefault();

		let FirstNameElement = document.getElementById('FirstName')
		FirstNameElement.value = generateQuickGuid(8);

		let LastNameElement = document.getElementById('LastName')
		LastNameElement.value = generateQuickGuid(8);

		let EmailElement = document.getElementById('Email')
		EmailElement.value = generateQuickGuid(6) + '@' + 'tr.bg';	
	});
});

$(function () {
	$("button.EditCommentarButtonJs").click(function (e) {
		e.preventDefault();

		let DivEditButton = e.target.parentElement;
		let ParentDiv = DivEditButton.parentElement;
		let CardCommentSection = ParentDiv.parentElement;
		let DivTextArea = ParentDiv.querySelector('.ComenntarTextAreaJs');
		let actionn = e.target.attributes[3].textContent;
		const tr = CardCommentSection.innerHTML;


		DivEditButton.remove();

		let textValues = DivTextArea.innerText;
		DivTextArea.textContent = "";

		let trEmelent = document.createElement('tr');

		let tdElement = document.createElement('td');
		let textArea = document.createElement('textarea');
		textArea.textContent = textValues;
		textArea.style.width = "300px";

		let okButton = document.createElement('input');
		let CancelButton = document.createElement('input');

		okButton.formAction = actionn;
		okButton.classList.add("btn", "btn-secondary", "mt-1");
		okButton.setAttribute("type","submit")
		okButton.value = "Запиши";

		CancelButton.classList.add("btn", "btn-danger", "mt-1", "cancelCommentar");
		CancelButton.setAttribute("type", "submit")
		CancelButton.value = "Откажи";
		CancelButton.addEventListener('click', function (e) {
			Array.from(CardCommentSection.children).map(x => x.remove());
			Array.from(tr.children).map(x => CardCommentSection.appendChild(x));

		});


		tdElement.appendChild(textArea);
		trEmelent.appendChild(tdElement);

		ParentDiv.appendChild(trEmelent);
		ParentDiv.appendChild(okButton);
		ParentDiv.appendChild(CancelButton);

	});
});


