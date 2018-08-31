function loadMovies() {
  var xhttp = new XMLHttpRequest();
  xhttp.open("GET", "http://localhost:55619/API/Movies", true);

  xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
      var data = JSON.parse(this.responseText);
      data.forEach(element => {
        console.log(element);
        var node = document.createElement("li");
        node.innerText =  "Title: " + element.MovieTitle + "\n" + " Genre: " + element.Genre;
        document.getElementById("movies").appendChild(node);
      });
    }
  };
  xhttp.send();
}

function loadComedy() {
  var xhttp = new XMLHttpRequest();
  xhttp.open("GET", "http://localhost:60053/api/Movies", true);

  xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
      var data = JSON.parse(this.responseText);
      data.forEach(element => {
        console.log(element);
        var node = document.createElement("ul");
        if (element.Genre == "Comedy")
          node.innerText =
            "Title: " + element.MovieTitle + "\n" + " Genre: " + element.Genre;
        document.getElementById("movies").appendChild(node);
      });
    }
  };
