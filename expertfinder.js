const expertData = [
  {
    name: "Tony Stark",
    occupation: "CEO of Stark Industries",
    skills: ["Python", "HTML", "Javascript"],
    photo: "https://vignette.wikia.nocookie.net/marvelhigh/images/8/8c/Tony_Stark.jpg/revision/latest?cb=20180331224523"
  },
  {
    name: "Bill Gates",
    occupation: "CEO of Microsoft",
    skills: ["Python", "C++", "C#"],
    photo: "https://thumbor.forbes.com/thumbor/fit-in/416x416/filters%3Aformat%28jpg%29/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5f4ebe0c87612dab4f12a597%2F0x0.jpg%3Fbackground%3D000000%26cropX1%3D292%26cropX2%3D3684%26cropY1%3D592%26cropY2%3D3987"
  },
  {
    name: "Cardeas Vist",
    occupation: "CEO of Anaheim Electronics",
    skills: ["MS OS.78", "NTD", "Machine Assembly"],
    photo: "https://vignette.wikia.nocookie.net/doppiaggio-italiano/images/b/be/IMG_0343.JPG/revision/latest?cb=20200417184130&path-prefix=it"
  }
];



function skills(skills) {
  return `
<h4>Skills</h4>
<ul class="skills-list">
${skills.map(skill => `<li>${skill}</li>`).join("")}
</ul>
`;
}

function expTemplate(expert) {
  return `
    <div class="expert">
    <img class="expert-photo" src="${expert.photo}">
    <h2 class="expert-name">${expert.name} <span class="occupation">(${expert.occupation})</span></h2>
    ${expert.skills ? skills(expert.skills) : ""}
    </div>
  `;
}

document.getElementById("app").innerHTML = `
  <h1 class="search-results">Experts (${expertData.length} results)</h1>
  ${expertData.map(expTemplate).join("")}
  <p class="footer">These ${expertData.length} experts were added recently. Check back soon for updates.</p>
`;