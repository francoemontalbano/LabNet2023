let numeroAleatorio;
let intentos;
let puntajeActual = 50;
let puntajeMasAlto = 0;
let maxIntentos = 5;

function generarNumero() {
    numeroAleatorio = Math.floor(Math.random() * 20) + 1;
}

function empezarJuego() {
    actualizarMensaje("");
    document.getElementById("numeroInput").disabled = true;
    document.getElementById("probarBtn").disabled = true;
    let nombre = document.getElementById("nombre").value;
    const soloLetras = /^[a-zA-Z]+$/.test(nombre);
    if (!soloLetras) {
        actualizarMensaje("Valores incorrectos. Solo se permiten letras");
        document.getElementById("mensaje").classList.add("rojo");
        document.getElementById("nombre").focus();
        return;
    }
    document.getElementById("numeroInput").disabled = false;
    document.getElementById("probarBtn").disabled = false;
    generarNumero();
    intentos = 0;
    puntajeActual = (puntajeActual === 0) ? 50 : puntajeActual;
    actualizarMensaje("Hola, " + nombre + "! ");
    actualizarPuntaje();
}

function adivinarNumero() {
    let numeroIngresado = parseInt(document.getElementById("numeroInput").value);
    if (numeroIngresado < 1 || numeroIngresado > 20 || isNaN(numeroIngresado)) {
        actualizarMensaje("Valores incorrectos. Solo se permiten números del 1 al 20\n");
        document.getElementById("mensaje").classList.add("rojo");
        document.getElementById("numeroInput").focus();
        return;
    }
    intentos++;

    if (numeroIngresado === numeroAleatorio) {
        actualizarMensaje("¡Felicidades, adivinaste el número en " + intentos + " intentos!\n" + "El juego comenzará nuevamente en 5 segundos");
        document.getElementById("mensaje").classList.add("ganaste");
        puntajeActual += 10;
        actualizarPuntaje();
        document.getElementById("nombre").value = "";
        document.getElementById("numeroInput").value = "";
        setTimeout(empezarJuego, 5000);
        if (puntajeActual > puntajeMasAlto) {
            puntajeMasAlto = puntajeActual;
        }
        actualizarPuntaje();
    } else if (numeroIngresado < numeroAleatorio) {
        actualizarMensaje("El número aleatorio es más alto.");
    } else {
        actualizarMensaje("El número aleatorio es más bajo.");
    }

    if (intentos >= maxIntentos) {
        puntajeActual -= 10;
        actualizarMensaje("Le erraste!. El número era " + numeroAleatorio + ". El juego comenzará nuevamente en 5 segundos");
        document.getElementById("mensaje").classList.add("perdiste");
        actualizarPuntaje();
        if (puntajeActual === 0) {
            actualizarMensaje("Perdiste!. El número era " + numeroAleatorio + ". El juego comenzará nuevamente en 5 segundos");
            document.getElementById("mensaje").classList.add("perdiste");
            document.getElementById("nombre").value = "";
            document.getElementById("numeroInput").value = "";
            setTimeout(empezarJuego, 5000);

        }
        document.getElementById("numeroInput").value = "";
        setTimeout(empezarJuego, 5000);
    }


}

function actualizarMensaje(mensaje) {

    document.getElementById("mensaje").innerHTML = mensaje;
    document.getElementById("mensaje").classList.remove("ganaste");
    document.getElementById("mensaje").classList.remove("perdiste");
    document.getElementById("mensaje").classList.remove("rojo");
}

function actualizarPuntaje() {
    document.getElementById("puntajeActual").innerHTML = puntajeActual;
    document.getElementById("puntajeMasAlto").innerHTML = puntajeMasAlto;
}
