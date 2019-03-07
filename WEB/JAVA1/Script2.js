alert("Merhaba Ziyaretçi");
function sayiToplam() {
    x = 8;
    y = 9;
    alert(8 + 9);
}

function alertYazdir() {
    var x = document.getElementById('kelime').innerHTML;
    alert(x);

}
function borderDegis() {

    var kutular = document.getElementsByClassName("kutu");
    var i;
    for (i = 0; i < kutular.length; i++) {
        kutular[i].style.border = "5px solid green";
    }
}
function renkDegistir() {

    var x = document.getElementById("kutu4").classList[0];
   
    if (x == "koyu")
    {
        document.getElementById("kutu4").classList.remove('koyu');
        document.getElementById("kutu4").classList.add('acik');

    }
    if (x == "acik") {
        document.getElementById("kutu4").classList.remove('acik');
        document.getElementById("kutu4").classList.add('koyu');

    }
}

