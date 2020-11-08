// JavaScript source code

const { link } = require("fs");

// Get the modal
var modal = document.getElementById('id01');

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
}

function gitHubPopup(username)
{
  console.log("triggered");

  var request = new XMLHttpRequest();

  var lineBreak = document.createElement("br");

  var popUp = document.getElementById('githubPopup');

  request.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
      var jsonResponse = JSON.parse(this.responseText);
      console.log(jsonResponse)

      popUp.style.display= "block";

      for (var i = 0; i < jsonResponse.length; i++)
      {        
        var repoName = document.createTextNode("Repo Name: " + jsonResponse[i].name + "\n");
        var repoDescription = document.createTextNode("Description: " + jsonResponse[i].description + " ");
        var repoUpdatedTS = document.createTextNode("Last Updated: " + jsonResponse[i].updated_at + " ");

        popUp.append(repoName);
        popUp.append(repoDescription);
        popUp.append(repoUpdatedTS);

        var newLink = document.createElement('a');
        newLink.href = jsonResponse[i].html_url;
        var linkTextNode = document.createTextNode(jsonResponse[i].full_name)
        newLink.appendChild(linkTextNode);
        popUp.appendChild(newLink);

        var lineBreak = document.createElement("br");
        popUp.append(lineBreak);

        console.log(jsonResponse[i].full_name);
      }
    }
  };

  request.open("GET", `https://api.github.com/users/${username}/repos`)
  
  request.send();

  console.log(request);

}

function gitHubPopupOut()
{
  var popUp = document.getElementById('githubPopup');
  popUp.style.display= "none";
}

function gitHubPopupIn()
{
  clearTimeout();
}