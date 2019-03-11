function sayiDeger() {


    var sinif = Number(document.getElementById("input_sayi").value);
    var i = 0;
    var txt = " ";
    for (i; i < sinif; i++) {
    
        if (i % 3 == 0) {
          
            txt += i+" ";
        }
        document.getElementById("ekle").innerHTML = txt;

        
    }
  
}
function renkDegistir() {

    var renk = document.getElementById("input_renk").value;
    document.getElementById("kutu2").style.backgroundColor = renk;

}
