// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

/* funcion para el popup de los borones de crear  */
/* let y const (var) 
var btnAbrirPopup = document.getElementById('btn-abrir-popup'),
	overlay = document.getElementById('overlay'),
	popup = document.getElementById('popup'),
	btnCerrarPopup = document.getElementById('btn-cerrar-popup');

btnAbrirPopup.onclick = function(){
	overlay.classList.add('active');
	popup.classList.add('active');
}

btnCerrarPopup.onclick = function(e) {
	e.preventDefault();
	overlay.classList.remove('active');
	popup.classList.remove('active');
}

/* --------------------------------------*/
