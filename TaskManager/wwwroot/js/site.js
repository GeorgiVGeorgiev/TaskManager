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

