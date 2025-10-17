
    function opcionCorrecta(valPreg, numPreg){

        let i = document.getElementById("Opcion" + numPreg);

        if (valPreg === "true") {
            i.style.color = "green"
        } else {
            i.style.color = "red"

        }

        let a = document.getElementById("Continuar");

        a.style.display = "inline-block"

    }