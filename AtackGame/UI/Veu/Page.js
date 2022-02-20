var theUrl="http://localhost:50845/api/GameApi"


function Gamer1Button() {
  var xhr = new XMLHttpRequest();
  
  xhr.onreadystatechange = function() {
    if (xhr.readyState === 4) {
      
    document.getElementById("Gamer2").innerHTML=xhr.response.toString();
    document.getElementById("gamer1btn").disabled = true;
    document.getElementById("Gamer2btn").disabled = false;
    if(xhr.response==0){
      window.alert("Oyun biti 2. oyuncu kazandı")
      window.location.reload()
     }
    }
  }
  xhr.open('GET', theUrl, true);
  xhr.send('');
}


function Gamer2Button(){
    var xhr = new XMLHttpRequest();
   
    xhr.onreadystatechange = function() {
      if (xhr.readyState === 4) {
      document.getElementById("Gamer1").innerHTML=xhr.response.toString();      
      document.getElementById("Gamer2btn").disabled = true;
      document.getElementById("gamer1btn").disabled = false;
      if(xhr.response==0){
        window.alert("Oyun biti 1. oyuncu kazandı")
        window.location.reload()
      }
      }
    }
      xhr.open('GET', theUrl, true);
      xhr.send('');
  }
  
    
    



