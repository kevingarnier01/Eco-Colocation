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

	eventCloseOrNotModal();

	//permet de correctement fermer le modal lors du click a l'exterieur
	$(document).on('mouseleave', '.reelModal', function () {
		eventCloseOrNotModal()
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
	//if ($('.blockerCenterToHideWindows').css('display') == 'none') {

	//Si le button close-modal à été cliqué, alors nous l'indiquons et l'evenement au dessus  (click sur modal)
	//se charge de ne pas faire disparaitre le scroll bar du body
	$(document).on('click', '.close-modal, .closeModal', function (e) {
		$('body').css('overflow', 'auto');
		closemodalhasbeenclicked = true;

		updateUrlModalAfterClosing();

		// entre les deux : ouvre l'evenement click du modal //
		settimeout(function () {
			closemodalhasbeenclicked = false; //puis réinitialise la variable à false
		}, 1000)
	});
	// Fin modal //	


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

function eventCloseOrNotModal() {
	$('.modal').on('click', '.underModal', function (e) {
		$('.jquery-modal').css('display', 'none');
		$('body').css('overflow', 'auto');
		setTimeout(function () {
			if ($('.jquery-modal').css('display') == 'none') {
				$(".ui-autocomplete").prependTo("body");
				$('.jquery-modal').remove();
				updateUrlModalAfterClosing();
			}
		}, 50)
	});
	$(document).on('click', '.modal', function (e) {
		$('.jquery-modal').css('display', 'none');
		$('body').css('overflow', 'auto');
		setTimeout(function () {
			if ($('.jquery-modal').css('display') == 'none') {
				$(".ui-autocomplete").prependTo("body");
				$('.jquery-modal').remove();
				updateUrlModalAfterClosing();
			}
		}, 50)
	});
}

//change de l'url quand le modal se ferme
function updateUrlModalAfterClosing() {
	window.history.replaceState("", $("#urlCurrentPage").val(), $("#urlCurrentPage").val());
}

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
		iconUrl: '/Content/Images/Logos/markerColocExisting.png',

		iconSize: [20, 20], // size of the icon
		//popupAnchor: [30, -76]  // point from which the popup should open relative to the iconAnchor
	});

	var leafIconOver = L.icon({
		iconUrl: '/Content/Images/Logos/mapLocalisationOVer.png',

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

				// specify popup options 
				var customOptions =
				{
					'className': 'leafletDivAnnounce'
				}

				var markerObject = L.marker(marker.latLng, { icon: leafIcon }).addTo(mymap).on("mouseover", function () {
					var numberId = ii + 1;
					var idElement = $("#onHoverMarker" + numberId);
					markerObject.bindPopup(idElement.html(), customOptions)
				}).on("mouseout", function () {
					hideAnnonce("#onHoverMarker", ii + 1);
				});

				$("#annonce" + (ii + 1) + "-alpv").on("mouseover", function (e) {
					markerObject.setIcon(leafIconOver);
				});

				$("#annonce" + (ii + 1) + "-alpv").on("mouseout", function (e) {
					markerObject.setIcon(leafIcon);
				}); showOthersEvents()

			}, 1000);
		})();
	}
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

var compteurPlace = 1;
function addNewPlace(inputId) {
	if ($(inputId + 'Hidden').val() == $(inputId).val()) {
		if (/[a-zA-Z]/.test($.trim($(inputId).val()))) {
			var htmlPlace =
				'<div id="place' + compteurPlace + '" class="divPlace-cpc">' +
				'<p id="placeName-cpc" class="placeName-cpc">' + $("#inputSearchPlace-mpc").val() + '</p>' +
				'<div class="crossPlace-cpc"><i onclick="deletePlace(place' + compteurPlace + ')" class="fas fa-times crossPlace-cpc"></i></div>' +
				'</div>';

			$("#place-cpc").append(htmlPlace);

			if ($("#placeSaved-cpc").css('display') == 'none')
				$("#placeSaved-cpc").css('display', 'block');

			$(inputId).val("");

			compteurPlace++;
		}
	}
	else {
		alert('Veuillez selectionner une des villes proposées par la liste d\'auto completion des villes.')
	}
}

function deletePlace(element) {
	$(element).remove();

	if ($('#placeSaved-cpc .divPlace-cpc').length == 0)
		$("#placeSaved-cpc").css('display', 'none');
}

function getLstAutoCompletion(arr, inputId, typeResearch) {
	if (arr.features.length > 0) {

		//Supprime les doublons		
		var labelThing; var labelT;
		arr.features = arr.features.filter((thing, index, self) =>
			index === self.findIndex((t) => (
				labelT = t.properties.label + t.properties.city + t.properties.context,
				labelThing = thing.properties.label + thing.properties.city + thing.properties.context,
				labelT === labelThing
			))
		)

		var availableTags = new Array();
		for (i = 0; i < arr.features.length; i++) {
			var label = arr.features[i].properties.label;
			var context = arr.features[i].properties.context;

			availableTags[i] = {
				label: ((typeResearch == "city") ?
					"<i class='iconAutoComplete fas fa-city'></i>" :
					"<i class='iconAutoComplete fas fa-map-marker-alt'></i>") +
					"<strong id='txtLabelAutoCompletion'>" + label + "</strong>" +
					"<p id='txtContextAutoCompletion'>" + context + "</p>",
				value: label + " " + context
			}

			//if (i == 0 && $('#listAutoCompletePlaceHidden').length != 0 && arr.features[0] == 1) {
			//	$('#listAutoCompletePlaceHidden').val() = availableTags[i];
			//}
		}

		$(inputId).autocomplete({
			source: function (request, response) {
				response(availableTags);
			},
			autoFocus: true,
			html: 'html',
			select: function (event, ui) {
				saveValueSelected(event, ui, this)
			}
		});
	}
}

function saveValueSelected(event, ui, input) {
	var selectedObj = ui.item;
	$("#" + input.id + "Hidden").val(selectedObj.value)
}

function addr_searchCity(inputId) {
	if ($(inputId).val() != "") {
		var inp = $(inputId);
		var url = "https://api-adresse.data.gouv.fr/search/?q=" + inp.val() + "&type=municipality";
		addr_search(url, inputId, "city")
	}
}

function addr_searchStreet(inputId) {
	if ($(inputId).val() != "") {
		var inp = $(inputId);
		var url = "https://api-adresse.data.gouv.fr/search/?q=" + inp.val() + "&type=street";
		addr_search(url, inputId, "street")
	}
}

//anciennement : var url = "https://nominatim.openstreetmap.org/search?format=json&limit=3&q=" + inp.value;
function addr_search(url, inputId, typeResearch) {
	initHtmlTagToAutoComplete();
	var xmlhttp = new XMLHttpRequest();

	xmlhttp.onreadystatechange = function () {
		if (this.readyState == 4 && this.status == 200) {
			var myArr = JSON.parse(this.responseText);
			getLstAutoCompletion(myArr, inputId, typeResearch);
		}
	};

	$(inputId).removeAttr("autocomplete").attr("autocomplete", "none");
	//debugger;
	xmlhttp.open("GET", url, true);
	xmlhttp.send();

	if ($('.listAutoCompleteToModal').length != 0) {
		$(".ui-autocomplete").prependTo(".listAutoCompleteToModal")
		i = 1;
	}
}

function autoCompletePrepend() {
	if ($('.listAutoCompleteToModal').length != 0) {
		$(".ui-autocomplete").prependTo("body");
	}
}

//Permet d'activer les element html (comme l'image) que je creer dans la list d'autocompletion
function initHtmlTagToAutoComplete() {

	(function ($) {
		var proto = $.ui.autocomplete.prototype,
			initSource = proto._initSource;

		function filter(array, term) {
			var matcher = new RegExp($.ui.autocomplete.escapeRegex(term), "i");
			return $.grep(array, function (value) {
				return matcher.test($("<div>").html(value.label || value.value || value).text());
			});
		}

		$.extend(proto, {
			_initSource: function () {
				if (this.options.html && $.isArray(this.options.source)) {
					this.source = function (request, response) {
						response(filter(this.options.source, request.term));
					};
				} else {
					initSource.call(this);
				}
			},

			_renderItem: function (ul, item) {
				return $("<li></li>")
					.data("item.autocomplete", item)
					.append($("<a></a>")[this.options.html ? "html" : "text"](item.label))
					.appendTo(ul);
			}
		});
	})(jQuery);
}


//Autocompletion avec algolia
//Si probleme utiliser l'api gratuit de valentin Eni : https://api-adresse.data.gouv.fr/search/
//https://notemoncoin.renard-valentin.fr/
//function initAutoComplete(elementId) {
//	var placesAutocomplete = places({
//		appId: 'plG5RW55OE5Z',
//		apiKey: '093af2800668c4b5a7d69e84e6a36b65',
//		container: document.querySelector(elementId)
//	});

//	placesAutocomplete.on('change', function resultSelected(e) {
//		$(".adresseVille").val(e.suggestion.name || '');
//		$(".adresseRegion").val(e.suggestion.administrative || '');
//		$(".adressePays").val(e.suggestion.country || '');
//		$(".adresseLatLng").val(e.suggestion.latlng.lat + "," + e.suggestion.latlng.lng || '');
//	});
//}

// Permet d'avoir toujours la list autocompletion gouv qui reste ouverte (permet de travailler sur le css en debug)

//var availableTags = [
//	{ label: 'Apple1', value: 'ValApple1' },
//	{ label: '<strong>Apple </strong> 2', value: 'ValApple2' },
//	{ label: 'Apple3', value: 'ValApple3' }
//]; $(".inputSearchPlace").autocomplete({
//	source: availableTags,

//	close: function (event, ui) {
//		val = $(".inputSearchPlace").val();
//		$(".inputSearchPlace").autocomplete("search", val); //keep autocomplete open by 

//		$(".inputSearchPlace").focus();
//		return false;
//	}
//});
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

function loadEcoRoommateMap() {
	var mymap = L.map('leafletMap_ereo').setView([46.89, 2.67], 5);

	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}', {
		maxZoom: 18,
		id: 'mapbox.streets',
		accessToken: 'pk.eyJ1Ijoia2dhcm5pZXIiLCJhIjoiY2pyajlmOW1nMDlmNDQ5bzAwemRoNTNpeSJ9.7Evwr47aOCoVYOAnds_WZA'
	}).addTo(mymap);

	loadEcoRoommateExistingMap(mymap);
	loadEcoRoommateEventMap(mymap);
}

function loadEcoRoommateExistingMap(mymap) {
	var markerIcon = L.icon({
		iconUrl: '/Content/Images/Logos/markerColocExisting.png',

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
			latLng: [46.91, 2.67],
			id: '2'
		},
	];

	for (var i = 0; i < data.length; i++) {
		(function () {
			var ii = i;
			var marker = data[ii]; 

			var customPopup = $('#ecoColocExistante' + marker.id).html();

			// specify popup options 
			var customOptions =
			{
				'className': 'leafletDivEcoRommateExisting'
			}

			var markerObject = L.marker(marker.latLng, { icon: markerIcon }).bindPopup(customPopup, customOptions).addTo(mymap).on("click", function () {
			});
		})();
	}
}

function loadEcoRoommateEventMap(mymap) {
	var markerIcon2 = L.icon({
		iconUrl: '/Content/Images/Logos/markerEvenement.png',

		iconSize: [22, 22], // size of the icon
	});

	var markerIconOver = L.icon({
		iconUrl: '/Content/Images/Logos/markerEvenementOver.png',

		iconSize: [22, 22],
	});

	var data2 = [
		{
			name: 'eventMarker1',
			latLng: [48.10, 2.10],
			id: '1'
		},
		{
			name: 'eventMarker2',
			latLng: [46.10, 2.10],
			id: '2'
		},
	];

	for (var i = 0; i < data2.length; i++) {
		(function () {
			var ii = i;
			var marker = data2[ii];

			//Recuperer l'element en fonction de l'id (eventMarker1 ou eventMarker2, etc.). L'id doit être le même que pour celui du data2
			var customPopup = $('#eventMarker' + marker.id)[0].outerHTML;
			
			//Pour le charge via une autre page : https://stackoverflow.com/questions/6203502/jquery-load-to-variable

			// specify popup options 
			var customOptions =
			{
				'className': 'leafletDivEcoRommateEvent'
			}

			var markerObject = L.marker(marker.latLng, { icon: markerIcon2 }).bindPopup(customPopup, customOptions).addTo(mymap).on("click", function () {
				checkIfBtnInteretIsNotEmpty_erevom('.leafletDivEcoRommateEvent #eventMarker' + marker.id);
			});

			$("#annonce" + (ii + 1) + "-ereom").on("mouseover", function (e) {
				markerObject.setIcon(markerIconOver);
			});

			$("#annonce" + (ii + 1) + "-ereom").on("mouseout", function (e) {
				markerObject.setIcon(markerIcon2);
			});
		})();
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

function checkIfBtnInteretIsNotEmpty_erevom(targetElement) {
	debugger
	if (!$(targetElement + ' #txtResultEventListChoose-erevom').text()) {
		changeBtnStillNotChoose(targetElement);
	}
}

function showListEvenementInterested_erevom(targetElement) {
	$(targetElement + ' .btnInterestedErevom').css('display', 'none');
	$(targetElement + ' .divListInterestedErevom').css('display', 'flex');
}

function checkIfEmailExistingInDB() {
	// Ajouter l'appel à la base de données

	//Si son email n'est pas enregistré
	// - L'enregistrer

	$('#divEmail-mgoi').css('display', 'none');
	$('#infoSup-mgoi').css('display', 'block');

	if ($('#modalGoingOrInterested').length != 0) {
		$('#divBtnSave-mgoi').css('display', 'flex');
	}
	else {
		$('#divBtnSaveNoModal-mgoi').css('display', 'flex');
	}

	//Sinon valider son interessement ou participation dans le cas où :
	// - son email n'existe pas
	//- son email existe mais les autres informations ne sont pas décrites (nom, prénom, date naissance, civilité)

	//validateListEventChoose(); <= pour valider son choix
}

function validateListEventChoose(targetElement) {
	var resultVal = $(targetElement + ' .listEvenementInterestedErevom').find(":selected").val();
	var result = $(targetElement + ' .listEvenementInterestedErevom').find(":selected").text();
	$(targetElement + " .txtResultEventListChooseErevom").text(result);

	if (resultVal == 1) {
		$(targetElement + " .iconInterestedErevom").attr('class', 'fas fa-check iconInterestedErevom');
		changeBtnChoose(targetElement);
	}
	else if (resultVal == 2) {
		$(targetElement + " .iconInterestedErevom").attr('class', 'fas fa-star iconInterestedErevom');
		changeBtnChoose(targetElement);
	}
	else {
		changeBtnStillNotChoose(targetElement)
	}

	$(targetElement + ' .btnInterestedErevom').css('display', 'flex');
	$(targetElement + ' .divListInterestedErevom').css('display', 'none');


	if ($('#modalGoingOrInterested').length == 0) {
		closeWindow()
	}
}

function changeBtnChoose(targetElement) {
	$(targetElement + ' .btnInterestedErevom').css('background-color', '#C4D102')
	$(targetElement + ' .btnInterestedErevom').css('border', 'initial')
	$(targetElement + ' .btnInterestedErevom').css('color', 'white')
}

function changeBtnStillNotChoose(targetElement) {
	$(targetElement + " .iconInterestedErevom").attr('class', 'fas fa-star iconInterestedErevom');
	$(targetElement + ' .btnInterestedErevom').css('background-color', 'white')
	$(targetElement + ' .btnInterestedErevom').css('border', 'solid 1px #C4D102')
	$(targetElement + ' .btnInterestedErevom').css('color', '#c4d10285')
	$(targetElement + ' .listEvenementInterestedErevom').val(2).change();
	var selectedElement = $(targetElement + ' .listEvenementInterestedErevom').find(":selected").text();
	$(targetElement + ' .txtResultEventListChooseErevom').text(selectedElement)
}

function openMessageWindow_merev() {

	if ($('#divMessage-ml').css('display') == 'none') {
		$('#divPhoto-ml').css('display', 'none');
		$('#divInterestedEmail-merev').css('display', 'none')
		$('#divMessage-ml').css('display', 'unset');
	}
	else {
		$('#divPhoto-ml').css('display', 'unset');
		$('#divMessage-ml').css('display', 'none');
	}
}

function openInterestedWindow_merev() {
	$('#divPhoto-ml').css('display', 'none');
	$('#divMessage-ml').css('display', 'none');
	$('#divInterestedEmail-merev').css('display', 'unset')
	$('#divEmail-mgoi').css('display', 'block');
}

function closeWindow() {
	$('#divPhoto-ml').css('display', 'unset');
	$('#divMessage-ml').css('display', 'none');
	$('#divInterestedEmail-merev').css('display', 'none');
	$('#infoSup-mgoi').css('display', 'none')
}

//Si le nombre de divEvent visbles n'est pas plus grand en taille que son conteneur alors enlever les fleches
function checkToShowArrowDivEvents() {
	var sizeContenerEvents = parseInt($('#divContenerOtherEvents-ayere').css('width'));
	var sizeDivEvent = parseInt($('.divElementEvent-ayer:first').css('width'), 10);

	var nbDivEvent = $('.divElementEvent-ayer').length;

	if ((sizeContenerEvents) < (sizeDivEvent * nbDivEvent)) {
		$('.btnDivOtherEvent-eyere').css('display', 'flex');
		$('#divContenerOtherEvents-ayere').css('margin-left', '55px');
		$('#divContenerOtherEvents-ayere').css('margin-right', '55px');
		$('#divContenerOtherEvents-ayere').css('overflow', 'hidden');
	}
}

function turnLeftOthersEvents(parentContener) {
	var sizeDivEvent = parseInt($('.divElementEvent-ayer:first').css('width'), 10);
	var currentPosition = parseInt($(parentContener + ' .divElementEvent-ayer:first').css('margin-left'), 10);

	if (currentPosition < 0) {
		$(parentContener + ' .divElementEvent-ayer:first').css('margin-left', currentPosition + sizeDivEvent + 'px')
	}
}

function turnRightOthersEvents(parentContener) {
	var sizeDivEvent = parseInt($('.divElementEvent-ayer:first').css('width'), 10);
	var currentPosition = parseInt($(parentContener + ' .divElementEvent-ayer:first').css('margin-left'), 10);

	var nbDivEvent = $('.divElementEvent-ayer').length;

	//Calcul du nombre de divEvent qui sont visbles sur l'écran
	var sizeContenerEvents = parseInt($('#divContenerOtherEvents-ayere').css('width'));
	var nbDivEventVisible = parseInt(((sizeContenerEvents / sizeDivEvent).toString().split(".")[0]));

	//sizeDivEvent * (nbDivEvent - 3); 3 étant le nombre de event visible
	if (currentPosition > '-' + (sizeDivEvent * (nbDivEvent - nbDivEventVisible))) {
		$(parentContener + ' .divElementEvent-ayer:first').css('margin-left', currentPosition - sizeDivEvent + 'px')
	}
}

function showOthersEvents() {
	// Appeler le controller pour recuperer quelques événements et les afficher
	var event = $('#divBlocAnnonce2').html();
	$("#divOthersEvents-ereom").append(event);

	//Afficher ces événements sur la carte
}

function showOthersAnnounces() {
	var announce = $("#annonce2-alpv")[0].outerHTML;
	$("#divOthersAnnounces-alpv").append(announce);
}

function showOthersPeople() {
	var people = $("#divPeoplesSearching")[0].outerHTML;
	$("#divOthersPeople-ps").append(people);
}