// JavaScript source code
// Get the modal
var modal = document.getElementById('id01');

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
}
  function linksArray() {
  var links = new Array('<img src="images/avatar.png" alt="Avatar" class="avatar">', 
  '<a href="https://github.com/" target="_blank"><img src="images/githubLogo.png" /></a>',
  '<a href="https://www.linkedin.com/" target="_blank"><img src="images/linkedinLogo.png" /></a>', 
  '<a href="https://google.com/gmail/" target="_blank"><img src="images/emailLogo.png" /></a>',
  '<p>Name/occupation/etc</p>',
  '<div class="profile_container" id="profile_container"></div>')
  document.getElementById("profile_holder").innerHTML = links.join(" ");
  profileArray();
  }
  linksArray();



  function profileArray() {
  var profiles = new Array('<a href="https://github.com/" target="_blank"><img src="images/profile.png" /></a>', 
  '<a href="https://github.com/" target="_blank"><img src="images/profile.png" /></a>', 
  '<a href="https://github.com/" target="_blank"><img src="images/profile.png" /></a>', 
  '<a href="https://github.com/" target="_blank"><img src="images/profile.png" /></a>');

  document.getElementById("profile_container").innerHTML = profiles.join(" ");
}
