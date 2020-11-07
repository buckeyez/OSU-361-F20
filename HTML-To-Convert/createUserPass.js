// JavaScript source code

document.addEventListener("DOMContentLoaded", activateBtns);

function activateBtns{

  document.getElementById("confirmBtn").addEventListener("click", function (event) {
    passwordOne = document.getElementById("password").value;
    passwordTwo = document.getElementById("password2").value;

    var result = accepted(passwordOne, passwordTwo);

    event.preventDefault();

    if (result == true) {
      // trigger account creation, and redirect user to page to fill out rest of their information.
    }
    else {
      var message = "Passwords do not match, please try again"
      document.getElementById("error").value = message;
    }
  }
}


function accepted(passwordOne, passwordTwo) {

  bool = passwordOne.localeCompare(passwordTwo);

  if (bool == 0) {
    return true;
  }

  else {
    return false;
  }

}
