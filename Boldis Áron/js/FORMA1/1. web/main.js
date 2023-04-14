
$(document).ready(function () {
  $('.navbar-nav li').click(function (x) {
    $('.navbar-nav li').removeClass('active');
    $(event.target).parent().addClass('active');
  });
});

function showCircuit() {
    $('#circuit').change(function (o) {
      switch (o.target.value) {
        case 'ITA':
          $('#circuitimage').attr('src', 'img/monza.jpg');
          $('#f1sound')[0].play();
          break;
        case 'HUN':
          $('#circuitimage').attr('src', 'img/hungaroring.jpg');
          break;
        case 'BEL':
          $('#circuitimage').attr('src', 'img/spa.jpg');
          break;
        case 'MON':
          $('#circuitimage').attr('src', 'img/monaco.jpg');
          break;

        default:
          break;
      }
    });
  }

//---------------------------------------------------------

function calculate(){
  var track = document.getElementById("circuit").value;
  var lptime = Number(document.getElementById("laptime").value);
  if (track && lptime){
    switch (track){
      case "HUN":
        document.getElementById("avaragespeed").value = (4.381 / (lptime/3600)).toString() + " km/h";
        break;
      case "MON":
        document.getElementById("avaragespeed").value = (3.337 / (lptime/3600)).toString() + " km/h";
        break;
      case "ITA":
        document.getElementById("avaragespeed").value = (5.793 / (lptime/3600)).toString() + " km/h";
        break;
      case "BEL":
        document.getElementById("avaragespeed").value = (7.004 / (lptime/3600)).toString() + " km/h";
        break;

      default:
        break;
    }
  }
}

  
