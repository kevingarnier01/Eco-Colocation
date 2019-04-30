var closeModalHasBeenClicked;
$(document).ready(function () {
	//http://pixelcog.github.io/parallax.js/
	$('.parallax-window').parallax({
		imageSrc: "http://www.ecocolocs.fr/bundles/app/images/image1.png"
		//, naturalheight: '50'
	});
	//$('.parallax-window').parallax();

	//Probleme initial, l'encadré ce ferme lors du clique à l'interieur du bloc
	$('.dropdown-menu').click(function (e) {
		e.stopPropagation();
	});

	//permet de correctement fermer le modal lors du click a l'exterieur
	$(document).on('mouseleave', '.reelModal', function () {
		$('.modal').on('click', '.underModal', function (e) {
			$('.jquery-modal').css('display', 'none');
			$('body').css('overflow', 'auto');
		});
		$(document).on('click', '.modal', function (e) {
			$('.jquery-modal').css('display', 'none');
			$('body').css('overflow', 'auto');
		});
	});

	$(document).on('mouseenter', '.reelModal', function () {
		$('body').css('overflow', 'hidden');
		$('.modal').on('click', '.underModal', function (e) {
			$('.jquery-modal').css('display', 'block');
			$('body').css('overflow', 'hidden');
		});
		$(document).on('click', '.modal', function (e) {
			$('.jquery-modal').css('display', 'block');
			if (!closeModalHasBeenClicked) {
				$('body').css('overflow', 'hidden');
			}
		});
	});

	//Si le button close-modal à été cliqué, alors nous l'indiquons et l'evenement au dessus  (click sur modal)
	//se charge de ne pas faire disparaitre le scroll bar du body
	$(document).on('click', '.close-modal, .closeModal', function () {
		closeModalHasBeenClicked = true;
		// Entre les deux : ouvre l'evenement click du modal //
		setTimeout(function () {
			closeModalHasBeenClicked = false; //puis réinitialise la variable à false
		}, 1000)
	});
	// Fin modal //

	//ModalProjetCreation. Can use enter button to valid a location place
	$(document).on('keypress', '#inputLocalisation-cpc', function (e) {
		var key = e.which;
		if (key == 13)  // the enter key code
		{
			addNewPlace();
		}
	});

	//ModalProjetCreation, when option 'Type d'engagement' list change.
	$(document).on('change', 'select#select-engagementType-mpc', function () {
		if ($(this).children(":selected").html() == 'Achat') {
			$('.rowByEngagement').css('display', 'none');
			$('#rowAchat').css('display', 'table-row');
			$('#rowLoyer').css('display', 'table-row');
		}
		else if ($(this).children(":selected").html() == 'Location') {
			$('.rowByEngagement').css('display', 'none');
			$('#rowLoyer').css('display', 'table-row');
		}
		else if ($(this).children(":selected").html() == 'Creation') {
			$('.rowByEngagement').css('display', 'none');
			$('#rowCreation').css('display', 'table-row');
			$('#rowTerrain').css('display', 'table-row');
		}
	});

});

function closeMenuNavbar() {
	$('#btnNavBar').click();
}

function modalResize() {
	var pourcent = $("#modalProjetCreation").width() / $(".modal").width() * 100;
	$('.modal').css('cssText', $('.modal').attr('style') + 'width: ' + (pourcent) + '% !IMPORTANT;');
}

function modalResize() {
	var pourcent = $("#modalProjetCreation").width() / $(".modal").width() * 100;
	$('.modal').css('cssText', $('.modal').attr('style') + 'width: ' + (pourcent) + '% !IMPORTANT;');
}

function initMap() {
	var mymap = L.map('mapSearchColoc').setView([46.89, 2.67], 5);

	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}', {
		maxZoom: 18,
		id: 'mapbox.streets',
		accessToken: 'pk.eyJ1Ijoia2dhcm5pZXIiLCJhIjoiY2pyajlmOW1nMDlmNDQ5bzAwemRoNTNpeSJ9.7Evwr47aOCoVYOAnds_WZA'
	}).addTo(mymap);

	var leafIcon = L.icon({
		iconUrl: '../Content/Images/Logos/markerColocExisting.png',

		iconSize: [20, 20], // size of the icon
		//popupAnchor: [30, -76]  // point from which the popup should open relative to the iconAnchor
	});

	var leafIconOver = L.icon({
		iconUrl: '../Content/Images/Logos/mapLocalisationOVer.png',

		iconSize: [20, 20], // size of the icon
		//popupAnchor: [30, -76]  // point from which the popup should open relative to the iconAnchor
	});

	var data = [
		{
			name: 'Marker1',
			latLng: [48.89, 2.67],
			id: '1'
		},
		{
			name: 'Marker2',
			latLng: [46.89, 2.67],
			id: '2'
		},
	];
	for (var i = 0; i < data.length; i++) {
		(function () {
			var ii = i;
			setTimeout(function () {
				var marker = data[ii];

				var markerObject = L.marker(marker.latLng, { icon: leafIcon }).addTo(mymap).on("mouseover", function () {
					showAnnonce("#onHoverMarker", ii + 1)
				}).on("mouseout", function () {
					hideAnnonce("#onHoverMarker", ii + 1);
				});

				$("#annonce" + (ii + 1) + "-alpv").on("mouseover", function (e) {
					markerObject.setIcon(leafIconOver);
				});

				$("#annonce" + (ii + 1) + "-alpv").on("mouseout", function (e) {
					markerObject.setIcon(leafIcon);
				});

				markerObject.on("mouseover", function (e) {
					markerObject.setIcon(leafIconOver);
				});

				markerObject.on("mouseout", function (e) {
					markerObject.setIcon(leafIcon);
				});

			}, 1000);
		})();
	}
}

function showAnnonce(idElement, numeroMarker) {
	var posx = 0;
	var posy = 0;
	if (!e) var e = window.event;
	if (e.pageX || e.pageY) {
		posx = e.pageX;
		posy = e.pageY;
	} else if (e.clientX || e.clientY) {
		posx = e.clientX;
		posy = e.clientY;
	}

	$(idElement + numeroMarker).css("display", "block");
	$(idElement + numeroMarker).css("position", "absolute");
	$(idElement + numeroMarker).css('left', posx + 20);
	$(idElement + numeroMarker).css('top', posy - 5);
}

function hideAnnonce(idElement, numeroMarker) {
	$(idElement + numeroMarker).css("display", "none");
	$(idElement + numeroMarker).css('left', 'inherit');
	$(idElement + numeroMarker).css('top', 'inherit');
}

function selectSwitcher(element) {
	if ($(element).attr("id") == 'btnCherche') {
		if ($(element).prop('checked') != true) {
			changeCssSwitcher(element, "#btnProposition")
			$("#typeRecherche").val("searching");
		}
	}
	else {
		if ($(element).prop('checked') != true) {
			changeCssSwitcher(element, "#btnCherche")
			$("#typeRecherche").val("offering");
		}
	}
}

function changeCssSwitcher(elementToEnable, elementToDisable) {
	$(elementToEnable).css("border", "2px solid rgba(0, 0, 0, 0.1)");
	$(elementToEnable).css("background-color", "rgba(0, 0, 0, 0.1)");

	$(elementToDisable).css("border", "none");
	$(elementToDisable).css("background-color", "white");

	$(elementToEnable).prop('checked', true);
	$(elementToDisable).prop('checked', false);
}

function annonceLocationPage() {
	$("#annonceLocation").css("display", "block");
	$("#projetCreation").css("display", "none");
	$("#creationRubrique2").css("border-bottom", "none");
	$("#annonceRubrique2").css("border-bottom", "3px solid #f7be68");
}

function projetCreationPage() {
	$("#annonceLocation").css("display", "none");
	$("#projetCreation").css("display", "block");
	$("#annonceRubrique2").css("border-bottom", "none");
	$("#creationRubrique2").css("border-bottom", "3px solid #f7be68");
}

/* SlideShow */
var slideIndex = 1;

function plusDivs(n) {
	showDivs(slideIndex += n);
}

function showDivs(n) {
	var i;
	var x = document.getElementsByClassName("mySlides");
	if (n > x.length) { slideIndex = 1 }
	if (n < 1) { slideIndex = x.length };
	for (i = 0; i < x.length; i++) {
		x[i].style.display = "none";
	}
	x[slideIndex - 1].style.display = "block";
}
/* End SlideShow */

function displayPVMessage() {
	if ($('#divMessage-ml').css('display') == 'none') {
		$('#divPhoto-ml').css('display', 'none');
		$('#divMessage-ml').css('display', 'unset');
	}
	else {
		$('#divPhoto-ml').css('display', 'unset');
		$('#divMessage-ml').css('display', 'none');
	}
}

function displayPhoneNumber(idElement) {
	var phone = '+33 6 56 21 30 45'
	$('#libelleTelephone-mpc').css('display', 'none');
	$(idElement).text(phone);
}

function displayMultiListe() {
	document.getElementById("div2-multiList").classList.toggle("show");
}

//Permet de fermer la liste checkbox
$('#div1-multiList').on('mouseleave', function () {
	$('#divfiltreHome').on('click', closeChildDropDown);
});
$('#div2-multiList').on('mouseleave', function () {
	$('#divfiltreHome').on('click', closeChildDropDown);
});
$('#div1-multiList').on('mouseenter', function () {
	$("#divfiltreHome").prop("onclick", null).off("click");
});
$('#div2-multiList').on('mouseenter', function () {
	$("#divfiltreHome").prop("onclick", null).off("click");
});

function closeChildDropDown(e) {
	if (!e.target.matches('#div1-multiList')) {
		var myDropdown = document.getElementById("div2-multiList");
		if (myDropdown.classList.contains('show')) {
			myDropdown.classList.remove('show');
		}
	}
}

window.onclick = function (e) {
	if (!e.target.matches('#div1-multiList')) {
		var myDropdown = document.getElementById("div2-multiList");
		if (myDropdown != null && myDropdown.classList.contains('show')) {
			myDropdown.classList.remove('show');
		}
	}
}
//Fin de la fermeture list checkBox

function deletePlace(element) {
	$(element).remove();
}

function updateSwitcher(typeRecherche) {
	if (typeRecherche == "searching") {
		changeCssSwitcher('#btnCherche', '#btnProposition')
	}
	else if (typeRecherche == "offering") {
		changeCssSwitcher('#btnProposition', '#btnCherche')
	}
}

//https://stackoverflow.com/questions/15919227/get-latitude-longitude-as-per-address-given-for-leaflet
//http://yellowthailand.com/leafletgeo.html
function chooseAddr(lat1, lng1) {
	myMarker.closePopup();
	map.setView([lat1, lng1], 18);
	myMarker.setLatLng([lat1, lng1]);
	lat = lat1.toFixed(8);
	lon = lng1.toFixed(8);
	document.getElementById('lat').value = lat;
	document.getElementById('lon').value = lon;
	myMarker.bindPopup("Lat " + lat + "<br />Lon " + lon).openPopup();
}


// -------------- nominatim.openstreetmap.org  ---------------

//Garder cette fonction en commentaire - cette utilisation concerne nominatim.openstreetmap.org 
//(Si algolia ne fonctionne plus, utiliser lui)

//var compteurPlace = 1;
//function addNewPlace(elementId) {
//	elementIdvalue = $('#' + elementId).val();
//	if (elementIdvalue != null) {
//		var nameElementId = JSON.parse(elementIdvalue)['display_name'];
//	}

//	console.log(nameElementId);
//	if (elementIdvalue != null && nameElementId == $("#inputLocalisation-cpc").val()) {
//		if (/[a-zA-Z]/.test($.trim($("#inputLocalisation-cpc").val()))) {
//			var htmlPlace =
//				'<div id="place' + compteurPlace + '" style="margin: auto;margin-left: initial;margin-right: 5px;margin-bottom:10px;padding-left: 5px;padding-right: 30px;padding-top: 3px;padding-bottom: 3px;background-color: rgba(0,0,0,0.15);border-radius: 15px;">' +
//				'<div style="display: inline-block;height: 100%;">' +
//				'<p id="placeName-cpc" style="margin: 0;">' + $("#inputLocalisation-cpc").val() + '</p>' +
//				'</div>' +
//				'<div style="display: inline-block;position:absolute">' +
//				'<div onclick="deletePlace(place' + compteurPlace + ')" style="background: url(https://www.gstatic.com/images/icons/material/system/1x/close_black_16dp.png) no-repeat;height: 15px;width: 17px;display: inline-block;margin-left: 5px;cursor: pointer;"></div>' +
//				'</div>' +
//				'</div>';

//			$("#place-cpc").append(htmlPlace);

//			$("#inputLocalisation-cpc").val("");

//			compteurPlace++;
//		}
//	}
//	else {
//		alert('S\'il vous plait, veuillez selectionner une localisation suggérer par les propositions.')
//	}
//}

//function myFunction(arr, inputId, listId) {
//	var out = "<br />";
//	var i;
//	if (arr.length > 0) {
//		$("#listAutoCompletePlaceHidden").val("");
//		for (i = 0; i < arr.length; i++) {
//			//out += "<div class='address' title='Show Location and Coordinates' onclick='chooseAddr(" + arr[i].lat + ", " + arr[i].lon + ");return false;'>" + arr[i].display_name + "</div>";
//			//out += "<div class='address' title='Show Location and Coordinates'>" + arr[i].display_name + "</div>";
//			out += "<option data-value='" + i + "'>" + arr[i].display_name + "</option>";

//			if ($('#' + inputId).val().replace(/\s/g, "") == arr[i].display_name.replace(/\s/g, "")) {
//				$("#" + listId + "Hidden").val(JSON.stringify(arr[i]));
//				//document.getElementById(listId + "Hidden").value = arr[i].lat + "," + arr[i].lon;
//			}
//		}
//		document.getElementById(listId).innerHTML = out;
//	}
//	else {
//		document.getElementById(listId).innerHTML = "";
//		$("#listAutoCompletePlaceHidden").val("");
//	}
//}

//function addr_search(inputId, listId) {
//	var inp = document.getElementById(inputId);
//	var xmlhttp = new XMLHttpRequest();
//	var url = "https://nominatim.openstreetmap.org/search?format=json&limit=3&q=" + inp.value;
//	xmlhttp.onreadystatechange = function () {
//		if (this.readyState == 4 && this.status == 200) {
//			var myArr = JSON.parse(this.responseText);
//			myFunction(myArr, inputId, listId);
//		}
//	};
//	xmlhttp.open("GET", url, true);
//	xmlhttp.send();
//}

// -------------- Fin nominatim.openstreetmap.org  ---------------

function openSecondModal() {

	setTimeout(function () {
		$('.modal').modal({
			closeExisting: false
		});

		$('.modal-backdrop').css('display', 'none');
	}, 1000);
}

function showMultiplesFilesUpload() {
	var filesInput = document.getElementById("file-upload");

	filesInput.addEventListener("change", function (event) {
		$('body').addClass('waiting');

		var files = event.target.files; //FileList object

		for (var i = 0; i < files.length; i++) {
			var file = files[i];

			//Only pics
			if (!file.type.match('image'))
				continue;

			var picReader = new FileReader();

			picReader.addEventListener("load", function (event) {

				var picFile = event.target;

				var elementHtml =
					'<li class="div2ResultFilesUpl-mcar">' +
					'<div class="div3ResultFilesUpl-mcar" >' +
					'<label class="labelDescFile-mcar">Photo de couverture</label>' +
					'<div class="resultPictureUpl-mcar" id="pictureUpl' + i + '-mcar"' +
					'style="background: url(' + picFile.result + ') 50% no-repeat;" ></div >' +
					'<i class="crossPictureUpl-mcar fas fa-times-circle"></i>' +
					'</div>' +
					'</li >';

				$("#divResultFilesUpl-mcar").append(elementHtml);
			});

			//Read the image
			picReader.readAsDataURL(file);

			setTimeout(function () {
				trierLesImagesUpl();
				setTimeout(function () {

					$('body').removeClass('waiting');
				}, 2000);
				$('.labelDescFile-mcar').css('display', 'block');
			}, 500);
		}
	});
}

function trierLesImagesUpl() {
	$('.div2ResultFilesUpl-mcar').each(function (index, element) {
		$(element).attr('id', 'div2ResultFilesUpl' + (index + 1) + '-mcar');
	});

	$('.crossPictureUpl-mcar').each(function (index, element) {
		$(element).attr("onclick", "removeUploadPicture('#div2ResultFilesUpl" + (index + 1) + "-mcar')");
	});

	$('.labelDescFile-mcar').each(function (index, element) {
		if (index == 0) {
			$(element).text('Photo de couverture')
		}
		else {
			$(element).text('photo n°' + (index + 1))
		}
	});

	//$('.resultPictureUpl-mcar').each(function (index, element) {
	//	$(element).attr('id', 'pictureUpl' + (index + 1) + '-mcar')
	//});
}

function removeUploadPicture(element) {
	$(element).remove();
	trierLesImagesUpl();
}

function initSlidepicture() {
	$(".all-slides").sortable({
		update: function () {
			trierLesImagesUpl()
		}
	});
}

function showDivCritereRecherche() {
	$('#divCritereRecherche-mcar').css('display', 'block')
}

function openDivCreateProfil(element) {
	if ($(element).css('display') == 'block') {
		$(element).css('display', 'none')
	}
	else {
		$(element).css('display', 'block')
	}
}

//Initialisation de l'input AutoCompletion des villes - algolia plugin
//Si probleme utiliser l'api gratuit de valentin Eni : https://api-adresse.data.gouv.fr/search/?type=housenumber&q=
//https://notemoncoin.renard-valentin.fr/
function initAutoComplete(elementId) {
	var placesAutocomplete = places({
		appId: 'plG5RW55OE5Z',
		apiKey: '093af2800668c4b5a7d69e84e6a36b65',
		container: document.querySelector(elementId)
	});

	placesAutocomplete.on('change', function resultSelected(e) {
		$(".adresseVille").val(e.suggestion.name || '');
		$(".adresseRegion").val(e.suggestion.administrative || '');
		$(".adressePays").val(e.suggestion.country || '');
		$(".adresseLatLng").val(e.suggestion.latlng.lat + "," + e.suggestion.latlng.lng || '');
	});
}

function switcherMcap(elementToEnable, elementToDisable) {
	$('body').addClass('waiting');
	$(elementToEnable).css("cursor", "inherit");
	$(elementToDisable).css("cursor", "inherit");

	$(elementToEnable).css('background-color', 'background-color: rgba(0, 0, 0, 0.2)');
	$(elementToDisable).css('background-color', 'inherit');

	if (elementToEnable == '#btnSwitcherPropose-mcap') {
		$('#resultSwitcher-mcap').load('../ColocAnnounce/ModalLocation #htmlBlockModalLocation-ml', function () {
			initAutoComplete("#address-input-ml");
		});
	}
	else {
		$('#resultSwitcher-mcap').load('../ColocAnnounce/ModalProjetCreation #htmlBlockModalCreationProjet-mpc', function () {
			initAutoComplete("#address-input-mpc");
		});
	}

	$('#divPersonnaliteInfo-mcap').load('../Account/ModalCARecherche #divPersonnaliteInfo-mcar');
	$('#divContactInfo-mcap').load('../Account/ModalCARecherche #divContactInfo-mcar');
	$('#divDesciptionInfo-mcap').load('../Account/ModalCARecherche #divDesciptionInfo-mcar', function () {
		$('#divCritereRecherche-mcar').remove();
		$('#infoPerso-mcap').css('display', 'block');
		$('body').removeClass('waiting');
		$(elementToEnable).css("cursor", "pointer");
		$(elementToDisable).css("cursor", "pointer")
	});
}

function loadEcoRoommateExistingMap() {
	var mymap = L.map('leafletMap_ereo').setView([46.89, 2.67], 5);

	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}', {
		maxZoom: 18,
		id: 'mapbox.streets',
		accessToken: 'pk.eyJ1Ijoia2dhcm5pZXIiLCJhIjoiY2pyajlmOW1nMDlmNDQ5bzAwemRoNTNpeSJ9.7Evwr47aOCoVYOAnds_WZA'
	}).addTo(mymap);

	var markerIcon = L.icon({
		iconUrl: '../Content/Images/Logos/markerColocExisting.png',

		iconSize: [22, 22], // size of the icon
	});

	var data = [
		{
			name: 'Marker1',
			latLng: [48.89, 2.67],
			id: '1'
		},
		{
			name: 'Marker2',
			latLng: [46.89, 2.67],
			id: '2'
		},
	];

	for (var i = 0; i < data.length; i++) {
		(function () {
			var ii = i;
			var marker = data[ii];

			var customPopup = $('.ecoRommateExisting-ereom').html();

			// specify popup options 
			var customOptions =
			{
				'className': 'leafletDivEcoRommateExisting'
			}

			var markerObject = L.marker(marker.latLng, { icon: markerIcon }).bindPopup(customPopup, customOptions).addTo(mymap).on("click", function () {
			});
		})();

		var markerIcon = L.icon({
			iconUrl: '../Content/Images/Logos/markerEvenement.png',

			iconSize: [22, 22], // size of the icon
		});

		var markerIconOver = L.icon({
			iconUrl: '../Content/Images/Logos/markerEvenementOver.png',

			iconSize: [22, 22],
		});

		var data2 = [
			{
				name: 'Marker1',
				latLng: [48.10, 2.10],
				id: '1'
			},
			{
				name: 'Marker2',
				latLng: [46.10, 2.10],
				id: '2'
			},
		];

		for (var i = 0; i < data2.length; i++) {
			(function () {
				var ii = i;
				var marker = data2[ii];

				var customPopup = $('.ecoRommateEvent-ereom').html();

				// specify popup options 
				var customOptions =
				{
					'className': 'leafletDivEcoRommateEvent'
				}

				var markerObject = L.marker(marker.latLng, { icon: markerIcon }).bindPopup(customPopup, customOptions).addTo(mymap).on("click");
				
				$("#annonce" + (ii + 1) + "-ereom").on("mouseover", function (e) {
					markerObject.setIcon(markerIconOver);
				});

				$("#annonce" + (ii + 1) + "-ereom").on("mouseout", function (e) {
					markerObject.setIcon(markerIcon);
				});
			})();
		}
	}
}

//********* EcoRoommateExisting *************//
// ---- Page AddYourEcoRoommateExisting ---- //
function openThisColocRow_ayer(elementTitle, elementBlockIdToOpen) {
	if ($(elementBlockIdToOpen).css('max-height') == '0px') {
		close_ayer();

		setTimeout(function () {
			$(elementBlockIdToOpen).css('max-height', '1000px');
			$(elementTitle).css('background-color', '#C4D102');
			$(elementTitle).css('color', 'white');
			$(elementTitle + " i").attr("class", "fas fa-long-arrow-alt-down iconTxtColocTable-ayer")
		}, 100)
	}
	else {
		close_ayer();
	}

	function close_ayer() {
		$('.titleInfoColocs-ayer').css('background-color', 'initial');
		$('.titleInfoColocs-ayer').css('color', '#555555');
		$('.infoColoc-ayer').css('max-height', '0');
		$(".iconTxtColocTable-ayer").attr("class", "fas fa-long-arrow-alt-right iconTxtColocTable-ayer")
	}
}

function modifyMinValueToNbInfoColoc(element) {
	if ($(element).val() > 2) {
		$('#valueNbColocInfo-ayer').attr("min", $(element).val());
	}
}

function removeOneColoc_ayer() {
	if ($('#valueNbColocInfo-ayer').val() > 2) {
		$('#valueNbColocInfo-ayer').val(parseInt($('#valueNbColocInfo-ayer').val()) - 1)
		if ($('#valueNbColocInfo-ayer').val() != 2) {
			$('#buttonMinusOne-ayer').attr("disabled", false);
		}

		//divColocInfo => Ajouter dans jquery lors de la création	
		if ($('.divColocInfo').length > 0) {
			var prenom = $('.divColocInfo:last-child .input-ayer:first-of-type').val();
			if (prenom != "") {
				if (confirm("L'enregistrement de \"" + prenom + "\" va être supprimé.")) {
					$('.divColocInfo:last-child').remove();
				}
				else {
					$('#valueNbColocInfo-ayer').val(parseInt($('#valueNbColocInfo-ayer').val()) + 1)
				}
			}
			else {
				$('.divColocInfo:last-child').remove();
			}
		}
		else {
			$('#buttonMinusOne-ayer').attr("disabled", true);
		}
	}
	else {
		$('#buttonMinusOne-ayer').attr("disabled", true);
	}
}

function addOneColoc_ayer() {
	var newValueNbBlockColocInfo = parseInt($('#valueNbColocInfo-ayer').val()) + 1;

	$('#valueNbColocInfo-ayer').val(newValueNbBlockColocInfo)

	if ($('#valueNbColocInfo-ayer').val() > 2) {
		$('#buttonMinusOne-ayer').attr("disabled", false);
	}

	//-1 de titleInfoColocs-ayer représente celui que sert de copie
	//-1 de valueNbColocInfo-ayer représente la valeur dont l'utilisateur vient d'ajouter
	if ($('.titleInfoColocs-ayer').length - 1 == (parseInt($('#valueNbColocInfo-ayer').val() - 1))) {
		var idName = "divColocInfo" + newValueNbBlockColocInfo;

		if ($(idName).length != 0) {
			$(idName).remove();
		}

		var newblock = "<div id='" + idName + "' class='divColocInfo'></div>"
		$('#addOthersColoc').append(newblock);

		var oneOfBlock = $('#colocCopie-ayer').html();
		$("#" + idName).append(oneOfBlock);

		$("#" + idName + ' #titleInfoColocCopie-ayer').attr("id", "titleInfoColoc" + newValueNbBlockColocInfo + "-ayer")
		$("#" + idName + ' .titleInfoColocs-ayer').attr('onclick',
			'openThisColocRow_ayer("#titleInfoColoc' + newValueNbBlockColocInfo + '-ayer","#infoColoc' + newValueNbBlockColocInfo + '-ayer")')
		$("#" + idName + ' .titleInfoColocs-ayer p').text("Colocataire " + newValueNbBlockColocInfo)
		$("#" + idName + ' #infoColocCopie-ayer').attr('id', 'infoColoc' + newValueNbBlockColocInfo + '-ayer')
	}
}

function uploadImgEcoRoommate() {
	$('body').addClass('waiting');

	var imgResult = $('#resultImgUpl-ayer')
	var file = document.querySelector('input[type=file]').files[0];
	var reader = new FileReader();

	reader.addEventListener("load", function () {

		imgResult.attr('src', reader.result)

		$('#divResultFilesUpl-ayer').css('display', 'inline-flex');

		
			$('body').removeClass('waiting');

	}, false);

	if (file) {
		reader.readAsDataURL(file);
	}
}

function removeUploadPicture_ayer() {
	$('#resultImgUpl-ayer').attr('src', '')
	$('#divResultFilesUpl-ayer').css('display', 'none');
	$("#fileUpload-ayer").val('')
}

function checkIfBtnInteretIsNotEmpty_erevom() {	
	if (!$('#txtResultEventListChoose-erevom').text()) {
		ChangeBtnStillNotChoose();
	}
}

function showListEvenementInterested_erevom() {
	var optionSelected = $("#txtResultEventListChoose-erevom").text();
	$("#listEvenementInterested-erevom").val(optionSelected);

	$('.btnInterestedErevom').css('display', 'none');
	$('.divListInterestedErevom').css('display', 'flex');	

}

function validateListEventChoose() {
	var resultVal = $('.listEvenementInterestedErevom').find(":selected").val();
	var result = $('.listEvenementInterestedErevom').find(":selected").text();	
	$(".txtResultEventListChooseErevom").text(result);
	
	if (resultVal == 1) {
		$(".iconInterestedErevom").attr('class', 'fas fa-check iconInterestedErevom');
		ChangeBtnChoose();
	}
	else if (resultVal == 2) {
		$(".iconInterestedErevom").attr('class', 'fas fa-star iconInterestedErevom');
		ChangeBtnChoose();
	}
	else {
		ChangeBtnStillNotChoose()
	}
	
	$('.btnInterestedErevom').css('display', 'flex');
	$('.divListInterestedErevom').css('display', 'none');	
}

function ChangeBtnChoose() {
	$('.btnInterestedErevom').css('background-color', '#C4D102')
	$('.btnInterestedErevom').css('border', 'initial')
	$('.btnInterestedErevom').css('color', 'white')
}

function ChangeBtnStillNotChoose() {
	$(".iconInterestedErevom").attr('class', 'fas fa-star iconInterestedErevom');
	$('.btnInterestedErevom').css('background-color', 'white')
	$('.btnInterestedErevom').css('border', 'solid 1px #C4D102')
	$('.btnInterestedErevom').css('color', '#c4d10285')
	$('.txtResultEventListChooseErevom').text('Intéressé(e)')
	$('.listEvenementInterestedErevom').val(2).change();
}