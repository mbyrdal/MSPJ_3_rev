function getResult() {
    var result = validateForm();
    if (result) {
        alert("Great!");
    } else {
        alert("Not so great!");
    }
}

function validateForm() {
    const name = document.getElementById("name").value;
    const house = document.getElementById("house-no").value;
    const ZIP= document.getElementById("post-no").value;
    const city = document.getElementById("city").value;
    const email = document.getElementById("email").value;
    const phone = document.getElementById("phone-no").value;

    /* Variables and constants... */
    var isInputValid = true;
    const namePattern = /^[A-Za-zÀ-ÖØ-öø-ÿ'’\- ]+$/; /* eg: Hans Petersen. */
    const zipCodePattern = /^\d{4}$/; /* eg: 9220. */
    const phoneNumberPattern = /(\+45)?^\d{8}$/; /* eg: +4512345678. */
    
    if (name == "" || !namePattern.test(name)) {
        alert("Invalid name. Please enter your name correctly.");
        isInputValid = false;
    }
    
    if (house == "") {
        alert("Invalid address. Please enter your address correctly (4 digits).");
        isInputValid = false;
    }
    
    if (ZIP == "" || !zipCodePattern.test(ZIP)) {
        console.log(`ZIP: ${ZIP}`);
        alert("Invalid ZIP code. Please enter your ZIP code correctly.");
        isInputValid = false;
    }

    if (city == "" || !namePattern.test(city)) {
        console.log(`city: ${city}`);
        alert("Invalid city. Please enter your city correctly.");
        isInputValid = false;
    }

    if (email == "" || !email.includes("@")) {
        alert("Invalid email. Please enter your email correctly.");
        isInputValid = false;
    }

    if (phone == "" || !phoneNumberPattern.test(phone)) {
        console.log(`phone no: ${phone}`);
        alert("Invalid phone number. Please enter your phone number correctly (8 digits).");
        isInputValid = false;
    }
    return isInputValid;
}

function clearAll() {
    document.getElementById("inputFormula").reset(); // clear the form
}