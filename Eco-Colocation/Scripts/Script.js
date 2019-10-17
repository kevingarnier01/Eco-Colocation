var closeModalHasBeenClicked;
$(document).ready(function () {
	//eventCloseOrNotModal();

	//permet de correctement fermer le modal lors du click a l'exterieur
	//$(document).on('mouseleave', '.reelModal', function () {
	//	//eventCloseOrNotModal()
	//});

	//$(document).on('mouseenter', '.reelModal', function () {
	//	$('body').css('overflow', 'hidden');
	//	$('.modal').on('click', '.underModal', function (e) {
	//		$('.jquery-modal').css('display', 'block');
	//		$('body').css('overflow', 'hidden');
	//	});
	//	$(document).on('click', '.modal', function (e) {
	//		$('.jquery-modal').css('display', 'block');
	//		if (!closeModalHasBeenClicked) {
	//			$('body').css('overflow', 'hidden');
	//		}
	//	});
	//});
	//if ($('.blockerCenterToHideWindows').css('display') == 'none') {

	//Si le button close-modal à été cliqué, alors nous l'indiquons et l'evenement au dessus  (click sur modal)
	//se charge de ne pas faire disparaitre le scroll bar du body
	$(document).on('click', '.close-modal, .closeModal', function (e) {
		stopNewTabOppening();

		$('body').css('overflow', 'auto');
		//closemodalhasbeenclicked = true;

		updateUrlModalAfterClosing();

		//// entre les deux : ouvre l'evenement click du modal //
		//settimeout(function () {
		//	closemodalhasbeenclicked = false; //puis réinitialise la variable à false
		//}, 1000)
	});
	// Fin modal //	

	//Probleme initial, l'encadré ce ferme lors du clique à l'interieur du bloc
	$('.dropdown-menu').click(function (e) {
		e.stopPropagation();
	});

	//ModalProjetCreation, when option 'Type d'engagement' list change.
	$(document).on('change', 'select#select-engagementTypeTerrain-mpc', function () {
		if ($(this).children(":selected").html() == 'Achat') {
			$("#nbParticipantAchatTerrainResearch-mpc").fadeIn("slow")
		}
		else if ($(this).children(":selected").html() == 'Location') {
			$("#nbParticipantAchatTerrainResearch-mpc").fadeOut("slow")
		}
	});
	$(document).on('change', 'select#select-engagementType-mpc', function () {
		if ($(this).children(":selected").html() == 'Achat') {
			$('#tableLogement-mpc .rowByEngagement').fadeOut("slow");
			$('#tableLogement-mpc #rowAchat').fadeIn("slow");
			$('#tableLogement-mpc #rowLoyer').fadeIn("slow");
			$("#nbParticipantAchatLogementResearch-mpc").fadeIn("slow")
		}
		else if ($(this).children(":selected").html() == 'Location') {
			$('#tableLogement-mpc .rowByEngagement').fadeOut("slow");
			$('#tableLogement-mpc #rowLoyer').fadeIn("slow");
			$("#nbParticipantAchatLogementResearch-mpc").fadeOut("slow")
		}
		else if ($(this).children(":selected").html() == 'Construction') {
			$('#tableLogement-mpc .rowByEngagement').fadeOut("slow");
			$('#tableLogement-mpc #rowCreation').fadeIn("slow");
			$("#nbParticipantAchatLogementResearch-mpc").fadeIn("slow")
		}
	});

	//engagement pour le terrain
	$(document).on('change', 'select#select-engagementTypeTerrain-mpc', function () {
		if ($(this).children(":selected").html() == 'Achat') {
			$('#tableTerrain-mpc #rowAchatTerrain').fadeIn("slow");
		}
		else if ($(this).children(":selected").html() == 'Location') {
			$('#tableTerrain-mpc #rowAchatTerrain').fadeOut("slow");
		}
	});

	// Captures click events of all <a> elements with href starting with #
	$("#btnPeopleSearch-ca").click(function (event) {
		event.preventDefault();

		$('html').animate({
			scrollTop: $($.attr(this, 'href')).offset().top - 100
		}, 500);
	});

	//Permet aux onglets "Les éco-colocation existantes" et "Les évènements" d'être positionné au dessus du titre
	$("#ecoColocExistTab-np, #evenementTab-np").click(function (event) {
		event.preventDefault();

		if (window.location.pathname + window.location.hash != $(this).attr('href')) {
			window.location.href = $(this).attr('href')
		}

		scrollDownTab(1000)
	});

	function scrollDownTab(time) {
		var target = $("#ecoColocExistTab-np").attr("href").split('#')[1];

		$('html').animate({
			scrollTop: $('#' + target).offset().top - 80
		}, time);
	}

	if (window.location.pathname + window.location.hash === $("#ecoColocExistTab-np").attr("href")
		|| window.location.pathname + window.location.hash === $("#evenementTab-np").attr("href")) {
		scrollDownTab(0.01);
	}
	//Fin "Permet aux onglets ..."

	//Permet de ne plus pouvoir ouvrir le modal sur un autre onglet
	stopNewTabOppening();
	openModalInThisTab();

	//Affiche la bulle de conversation réduite uniquement s'il n'est pas sur la page d'accueil
	if (window.location.pathname != "/" && window.location.pathname != "/Home" && window.location.pathname != "/Home/Index") {
		appearAndReduceWindowsConvDev()
	}
});

/***** Permet de ne plus pouvoir ouvrir le modal sur un autre onglet *****/
function stopNewTabOppening() {
	$('a').each(function () {
		if ($(this).attr('rel')) {
			var href = $(this).attr('href');
			$(this).removeAttr('href');
			//$(this).attr('onclick', "openModalInThisTab()");
			if (!$(this).attr('jshref')) {
				$(this).attr('jshref', href); //add new attribte
			}
		}
	});
}

function openModalInThisTab() {
	$('a').bind('click', function (e) {
		if ($(this).attr('jshref')) {
			var href = $(this).attr('jshref');
			$(this).attr('href', href);
			$(this).removeAttr('jshref');
			$(this).click();
		}
	});
}
/***** Fin = Permet de ne plus pouvoir ouvrir le modal sur un autre onglet *****/

//function eventCloseOrNotModal() {
//	$('.modal').on('click', '.underModal', function (e) {
//		$('.jquery-modal').css('display', 'none');
//		$('body').css('overflow', 'auto');
//		setTimeout(function () {
//			if ($('.jquery-modal').css('display') == 'none') {
//				$(".ui-autocomplete").prependTo("body");
//				$('.jquery-modal').remove();
//				updateUrlModalAfterClosing();
//			}
//		}, 50)
//	});
//	$(document).on('click', '.modal', function (e) {
//		$('.jquery-modal').css('display', 'none');
//		$('body').css('overflow', 'auto');
//		setTimeout(function () {
//			if ($('.jquery-modal').css('display') == 'none') {
//				$(".ui-autocomplete").prependTo("body");
//				$('.jquery-modal').remove();
//				updateUrlModalAfterClosing();
//			}
//		}, 50)
//	});
//}

//change de l'url quand le modal se ferme
function updateUrlModalAfterClosing() {
	if ($('#currentTab').val().length != 0) {
		window.history.replaceState("", "", $("#urlCurrentPage").val() + "/?currentTab=" + $('#currentTab').val());
	}
	else {
		window.history.replaceState("", "", $("#urlCurrentPage").val());
	}
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

function initmarkersCluster(specialDigits) {
	var markersCluster = new L.MarkerClusterGroup({
		iconCreateFunction: function (cluster) {
			var digits = cluster.getChildCount();

			if (digits < 10) {
				digits = 1;
			}
			else if (digits >= 10 && digits < 100) {
				digits = 2;
			}
			else {
				digits = 3;
			}

			//var markers = cluster.getAllChildMarkers();
			//var latlng = markers[1].getLatLng();
			//var lat = latlng.lat.toString();
			//var idCluster = lat.substr(lat.indexOf(".") + 1)

			return L.divIcon({
				html: "<div><span>" + cluster.getChildCount() + "</span></div>",
				className: ' markersCluster ' + ((specialDigits != null && specialDigits.length != 0) ? specialDigits : "") + ' digits-' + digits,
				iconSize: null
			});
		}
	});
	return markersCluster;
}

function initSearchColocMap() {
	var mymap = L.map('mapSearchColoc').setView([46.89, 2.67], 5);

	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}', {
		maxZoom: 18,
		id: 'mapbox.streets',
		accessToken: 'pk.eyJ1Ijoia2dhcm5pZXIiLCJhIjoiY2pyajlmOW1nMDlmNDQ5bzAwemRoNTNpeSJ9.7Evwr47aOCoVYOAnds_WZA'
	}).addTo(mymap);

	var leafIcon = L.icon({
		iconUrl: '/Content/Images/Logos/mapLocalisationOver.png',

		iconSize: [30, 30], // size of the icon
		//popupAnchor: [30, -76]  // point from which the popup should open relative to the iconAnchor
	});

	var leafIconOver = L.icon({
		iconUrl: '/Content/Images/Logos/markerColocExisting.png',

		iconSize: [40, 40], // size of the icon
		//popupAnchor: [30, -76]  // point from which the popup should open relative to the iconAnchor
	});

	var data = [
		{
			name: 'Marker1',
			latLng: [48.101228, -1.686257],
			id: '1'
		},
		{
			name: 'Marker2',
			latLng: [48.131728, -1.636257],
			id: '2'
		},
		{
			name: 'Marker3',
			latLng: [46.89, 2.67],
			id: '3'
		}, {
			name: 'Marker4',
			latLng: [46.91, 2.67],
			id: '4'
		}
	];

	var markersCluster = initmarkersCluster();

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

				//var markerObject = L.marker(marker.latLng, { icon: leafIcon }).on("mouseover", function () {
				//	var numberId = ii + 1;
				//	var idElement = $("#onHoverMarker" + numberId);
				//	markerObject.bindPopup(idElement.html(), customOptions)
				//});

				var numberId = ii + 1;
				var idElement = $("#onHoverMarker" + numberId);
				var markerObject = L.marker(marker.latLng, { icon: leafIcon }).bindPopup(idElement.html(), customOptions).on("click", function () {
					stopNewTabOppening();
					openModalInThisTab();
				});

				$("#annonce" + (ii + 1) + "-alpv").on("mouseover", function (e) {
					markerObject.setIcon(leafIconOver);

					//var backgroundcolor = $(".markersCluster" + randomNumber).css("background-color");

					//this.iid = setInterval(function () {						
					//		$(".markersCluster" + randomNumber).css("background-color", "transparent")
					//}, 1000);

				});

				$("#annonce" + (ii + 1) + "-alpv").on("mouseout", function (e) {
					markerObject.setIcon(leafIcon);
					//clearInterval(this.iid)
				});

				showOthersEvents()

				markersCluster.addLayer(markerObject);
				mymap.fitBounds(markersCluster.getBounds());
			}, 1000);
		})();
	}

	mymap.addLayer(markersCluster);
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
	$(elementToEnable).css("background-color", "#C4D102");
	$(elementToEnable).css("color", "white");
	$(elementToEnable).css("font-size", "21px");

	$(elementToDisable).css("background-color", "white");
	$(elementToDisable).css("font-size", "18px");
	$(elementToDisable).css("color", "inherit");

	$(elementToEnable).prop('checked', true);
	$(elementToDisable).prop('checked', false);
}

function annonceLocationPage() {
	$("#annonceLocation").css("display", "block");
	$("#projetCreation").css("display", "none");
	$("#creationRubrique2").css("border-bottom", "none");
	$("#annonceRubrique2").css("border-bottom", "3px solid #e9e5c3");

	$('#currentTab').val("AnnonceLocation");
	window.history.replaceState('data to be passed', 'Title of the page', $('#urlCurrentPage').val() + '/?currentTab=AnnonceLocation')
}

function projetCreationPage() {
	$("#annonceLocation").css("display", "none");
	$("#projetCreation").css("display", "block");
	$("#annonceRubrique2").css("border-bottom", "none");
	$("#creationRubrique2").css("border-bottom", "3px solid #e9e5c3");

	$('#currentTab').val("ProjetCreation");
	window.history.replaceState('data to be passed', 'Title of the page', $('#urlCurrentPage').val() + '/?currentTab=ProjetCreation')
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
		$('#divMessage-ml').css('display', 'inherit');
	}
	else {
		$('#divPhoto-ml').css('display', 'inline');
		$('#divMessage-ml').css('display', 'none');
	}
}

function displayPhoneNumber(idElement) {
	var phone = '+33 6 56 21 30 45'
	$('#libelleTelephone-mpc').css('display', 'none');
	$(idElement).text(phone);
}

function checkIfIsChecked_fal(elementCheck, actualTitle, titleToChange) {
	if ($(elementCheck + ':checked').length != 0) {
		$(titleToChange).text($(actualTitle).text() + "(" + $(elementCheck + ':checked').length + ")");
	}
	else {
		$(titleToChange).text('Choix multiples')
	}
}

function unCheckedAllItem_fal(elementsToUnchecked, elementTextToChange) {
	$(elementsToUnchecked).attr("checked", false);
	$(elementTextToChange).text('Choix multiples')
}

function displayMultiListe(listElement) {
	if ($('#' + listElement).css('display') != "block") {
		setTimeout(function () {
			closeChildDropDown();
			document.getElementById(listElement).classList.toggle("show");
		}, 50);
	}
	else {
		document.getElementById(listElement).classList.remove('show');
	}
}

//Permet de fermer la liste checkbox
$('.div1-multiList').on('mouseleave', function () {
	$('#divfiltreHome').on('click', closeChildDropDown);
});
$('.div2-multiList').on('mouseleave', function () {
	$('#divfiltreHome').on('click', closeChildDropDown);
});
$('.div1-multiList').on('mouseenter', function () {
	$("#divfiltreHome").prop("onclick", null).off("click");
});
$('.div2-multiList').on('mouseenter', function () {
	$("#divfiltreHome").prop("onclick", null).off("click");
});

function closeChildDropDown() {
	if ($('.div2-multiList').length != 0) {
		for (i = 0; i < $('.div2-multiList').length; i++) {
			if ($('.div2-multiList') != null) {
				var myDropdown = document.getElementsByClassName("div2-multiList");
				if (myDropdown[i].classList.contains('show')) {
					myDropdown[i].classList.remove('show');
				}
			}
		}
	}
}

window.onclick = function (e) {
	closeChildDropDown()
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

var compteurPlaceItem = 100;
function addNewPlaceItem(ui, inputId, identityPage) {
	var locationNameSelected = ui.item.value;

	var htmlPlace =
		(identityPage != "ph") ?
			'<div id="place' + identityPage + compteurPlaceItem + '" class="divPlace">'
			: '<div id="place' + identityPage + compteurPlaceItem + '" class="divPlace divPlace-ph">'
	htmlPlace +=
		'<p class="placeName" title="' + locationNameSelected + '">' + locationNameSelected + '</p>' +
		'<div class="crossPlace"><i onclick="deletePlace(place' + identityPage + compteurPlaceItem + ', \'' + identityPage + '\')" class="fas fa-times crossPlace"></i></div>' +
		'</div>';

	$("#place-" + identityPage).append(htmlPlace);

	if ($("#placeSaved-" + identityPage).css('display') == 'none')
		$("#placeSaved-" + identityPage).css('display', 'block');

	setTimeout(function () {
		$(inputId).val("");
	}, 10)

	compteurPlaceItem++;
}

function deletePlace(element, identityPage) {
	$(element).remove();

	if ($('#placeSaved-' + identityPage + ' .divPlace').length == 0) {
		$("#placeSaved-" + identityPage).css('display', 'none');
		if (identityPage == "ph") {
			$('#inputSearchPlace-ph').val("")
			$('#typeResearchSct-ph').removeAttr('disabled')
		}
	}
}

function getLstAutoCompletion(arr, inputId, typeResearch) {

	if (arr.length != null) {
		arr.features = arr;
	}

	if (arr.features.length > 0) {

		//Supprime les doublons		
		var labelThing; var labelT;
		arr.features = arr.features.filter(function (thing, index, self) {

			var indexItem = -1;
			for (var i = 0; i < self.length; i++) {
				var t = self[i];
				if (typeResearch == "region" || typeResearch == "departement") {
					labelT = t.nom;
					labelThing = t.nom;
				}
				else {
					labelT = t.properties.label + t.properties.city + t.properties.context;
					labelThing = thing.properties.label + thing.properties.city + thing.properties.context;
				}
				if (labelT === labelThing) {
					indexItem = i;
					break;
				}
			}
			if (index === indexItem) {
				return true;
			}
		});

		var availableTags = new Array();
		for (i = 0; i < arr.features.length; i++) {
			if (typeResearch == "region" || typeResearch == "departement") {
				var label = arr.features[i].nom;
				var context = "";
			}
			else {
				var label = arr.features[i].properties.label;
				var context = arr.features[i].properties.context;
			}

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
				if (inputId.id == "inpMultiPlace-al") {
					addNewPlaceItem(ui, inputId, "al");
				}
				else if (inputId.id == "inputSearchPlace-ph") {
					addNewPlaceItem(ui, inputId, "ph");
				}
				else if (inputId.id == "inputSearchPlace-mpc") {
					addNewPlaceItem(ui, inputId, "mpc")
				}
				else if (inputId.id == "inputSearchPlace-car") {
					addNewPlaceItem(ui, inputId, "car")
				}
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

function addr_searchRegion(inputId) {
	if ($(inputId).val() != "") {
		var inp = $(inputId);
		var url = "https://geo.api.gouv.fr/regions?nom=" + inp.val() + "&limit=5"
		addr_search(url, inputId, "region")
	}
}

function addr_searchDepartement(inputId) {
	if ($(inputId).val() != "") {
		var inp = $(inputId);
		var url = "https://geo.api.gouv.fr/departements?nom=" + inp.val() + "&limit=5"
		addr_search(url, inputId, "departement")
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
	//Permet de contourner l'attribute autoCompelte off qui ne fonctionne pas sur otut les navigateurs.
	if ($(inputId).attr("name") == null) {
		$(inputId).attr("name", "inputAutoComplete" + Math.random())
	}
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

function checkToDisableLstOrNot(element) {
	if (element.value.length != 0) {
		$('#typeResearchSct-ph').attr('disabled', 'true')
	}
	else {
		$('#typeResearchSct-ph').removeAttr('disabled')
	}
}

function modifyNbChambreDisponible(elementNbChambreAsk, blockElementRoom) {
	if ($(elementNbChambreAsk).val() >= 1) {
		while ($(elementNbChambreAsk).val() != $(blockElementRoom).length) {
			if ($(elementNbChambreAsk).val() > $(blockElementRoom).length) {
				var divChambre = $(blockElementRoom)[0].outerHTML;
				$(blockElementRoom).last().after(divChambre);
				$(blockElementRoom + ':last #titleChambre-ml').text('CHAMBRE ' + $(blockElementRoom).length);
			}
			else if ($(elementNbChambreAsk).val() < $(blockElementRoom).length && $(blockElementRoom).length > 1) {
				var numberDifference = $(blockElementRoom).length - $(elementNbChambreAsk).val();
				if (numberDifference < 2) {
					if ($('#msgJqueryNbChambre-ml').val() == 0) {
						if (confirm("Cette action supprimera la dernière chambre qui à été ajoutée.")) {
							$('.divGlobalChambre-ml').last().remove();
							$('#msgJqueryNbChambre-ml').val(1);
						}
						else {
							$(elementNbChambreAsk).val(parseInt($(elementNbChambreAsk).val()) + 1)
						}
					}
					else {
						$('.divGlobalChambre-ml').last().remove();
					}
				}
				else {
					if (confirm("Les " + numberDifference + " dernières chambres vont être retirées.")) {
						for (i = 0; i < numberDifference; i++) {
							$('.divGlobalChambre-ml').last().remove();
						}
						break;
					} else {
						$(elementNbChambreAsk).val($(blockElementRoom).length)
					}
				}
			}
		}
	}
}

function openSecondModal() {

	setTimeout(function () {
		$('.modal').modal({
			closeExisting: false
		});

		$('.modal-backdrop').css('display', 'none');
	}, 1000);
}

function showMultiplesFilesUpload(filesInputId, elementIdToAppend) {
	var filesInput = document.getElementById(filesInputId);

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
					'<i class="fas fa-arrows-alt imgCursorMove"></i>' +
					'</div>' +
					'</li >';

				$("#" + elementIdToAppend).append(elementHtml);
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
		$('input[type="file"]').val(null);
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

//********* Acccount *************//

function redirectAfterConnection() {
	$.ajax({
		url: "/Account/Index",
		type: 'post',
		datatype: 'json',
		//data: $("#form").serialize() + "&urlCurrentPage=" + $('#urlCurrentPage').val(), //A redefinir le vrai id !!!
		data: "urlCurrentPage=" + $('#urlCurrentPage').val(),
		success: function (result) {
			//$('body').html(result);
			//$('body').css("overflow", "auto");
			window.history.replaceState('data to be passed', 'Title of the page', $('#urlCurrentPage').val());
			location.reload();
		}
	});
}

//********* Fin Acccount *************//

function showDivCritereRecherche() {
	$('#divCritereRecherche-mcar').css('display', 'block')
}

function openDivElement(element) {
	if ($(element).css('display') == 'block') {
		$(element).css('display', 'none')
	}
	else {
		$(element).css('display', 'block')
	}
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
		iconUrl: '/Content/Images/Logos/markerColocExistingOnMap.png',

		iconSize: [30, 30], // size of the icon
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
		}
	];

	var markersCluster = initmarkersCluster('digitsColocExistante');

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

			var markerObject = L.marker(marker.latLng, { icon: markerIcon }).bindPopup(customPopup, customOptions).on("click", function () {
				stopNewTabOppening();
				openModalInThisTab();
			});

			markersCluster.addLayer(markerObject);
		})();
	}

	mymap.addLayer(markersCluster);
}

function loadEcoRoommateEventMap(mymap) {
	var markerIcon2 = L.icon({
		iconUrl: '/Content/Images/Logos/markerEvenement.png',

		iconSize: [30, 30], // size of the icon
	});

	var markerIconOver = L.icon({
		iconUrl: '/Content/Images/Logos/markerEvenement.png',

		iconSize: [43, 43],
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

	var markersCluster = initmarkersCluster('digitsEvent');

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

			var markerObject = L.marker(marker.latLng, { icon: markerIcon2 }).bindPopup(customPopup, customOptions).on("click", function () {
				checkIfBtnInteretIsNotEmpty_erevom('.leafletDivEcoRommateEvent #eventMarker' + marker.id);
				stopNewTabOppening();
				openModalInThisTab();
			});

			$("#annonce" + (ii + 1) + "-ereom").on("mouseover", function (e) {
				markerObject.setIcon(markerIconOver);
			});

			$("#annonce" + (ii + 1) + "-ereom").on("mouseout", function (e) {
				markerObject.setIcon(markerIcon2);
			});


			markersCluster.addLayer(markerObject);
		})();
	}
	mymap.addLayer(markersCluster);
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
			$(elementTitle + " i:first-child").css("color", "white")
			$(elementTitle + " i:last-child").attr("class", "fas fa-long-arrow-alt-down iconTxtColocTable-ayer")
		}, 100)
	}
	else {
		close_ayer();
	}

	function close_ayer() {
		$('.titleInfoColocs-ayer').css('background-color', 'initial');
		$('.titleInfoColocs-ayer').css('color', '#555555');
		$('.infoColoc-ayer').css('max-height', '0');
		$(".crossEcoColocExisting-ayere").css("color", "#555")
		$(".iconTxtColocTable-ayer").attr("class", "fas fa-long-arrow-alt-right iconTxtColocTable-ayer")
	}
}

function modifyMinValueToNbInfoColoc(element) {
	if ($(element).val() > 2) {
		$('#valueNbColocInfo-ayer').attr("min", $(element).val());
	}
}

function removeOneColoc_ayer() {
	if ($('#valueNbColocInfo-ayer').val() > 1) {
		$('#valueNbColocInfo-ayer').val(parseInt($('#valueNbColocInfo-ayer').val()) - 1)
		if ($('#valueNbColocInfo-ayer').val() != 1) {
			$('#buttonMinusOne-ayer').attr("disabled", false);
		}
		else if ($('#valueNbColocInfo-ayer').val() <= 1) {
			$('#buttonMinusOne-ayer').attr("disabled", true);
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
	}
	else {
		$('#buttonMinusOne-ayer').attr("disabled", true);
	}
}

function removeSpecificColoc(event, elementToRemove) {
	if ($(elementToRemove + ' .prenomColoc-ayer').val().length != 0) {
		if (confirm('Êtes-Vous sûr de vouloir supprimer "' + $(elementToRemove + ' .prenomColoc-ayer').val() + '" de la liste ?')) {
			removeIt(elementToRemove);
		}
	}
	else {
		if (confirm('Êtes-Vous sûr de vouloir supprimer ' + $(elementToRemove + ' .txtColocTable-ayer').text() + ' de la liste ?')) {
			removeIt(elementToRemove);
		}
	}

	function removeIt(elementToRemove) {
		if ($('#valueNbColocInfo-ayer').val() > 1) {
			$(elementToRemove).remove();

			var newValueNbBlockColocInfo = parseInt($('#valueNbColocInfo-ayer').val()) - 1;
			$('#valueNbColocInfo-ayer').val(newValueNbBlockColocInfo)

			var colocActual = 2
			$('.divColocInfo').each(function () {
				$('#' + this.id).attr("id", "divColocInfo" + colocActual)
				$('#' + this.id + ' .titleInfoColocs-ayer').attr("id", "titleInfoColoc" + colocActual + "-ayer")
				$('#' + this.id + ' .titleInfoColocs-ayer').attr('onclick',
					'openThisColocRow_ayer("#titleInfoColoc' + colocActual + '-ayer","#infoColoc' + colocActual + '-ayer")')
				$('#' + this.id + ' .txtColocTable-ayer').text("Colocataire " + colocActual)
				$('#' + this.id + ' .infoColoc-ayer').attr('id', 'infoColoc' + colocActual + '-ayer')
				$('#' + this.id + ' .crossEcoColocExisting-ayere').attr("onclick", "removeSpecificColoc(event, '#divColocInfo" + colocActual + "')")

				colocActual += 1;
			});
		}
		event.stopPropagation();
	}
}

function addOneColoc_ayer() {
	var newValueNbBlockColocInfo = parseInt($('#valueNbColocInfo-ayer').val()) + 1;

	$('#valueNbColocInfo-ayer').val(newValueNbBlockColocInfo)

	if ($('#valueNbColocInfo-ayer').val() > 1) {
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
		$("#" + idName + ' #crossEcoColocExist-ayere').attr("onclick", "removeSpecificColoc(event, '#divColocInfo" + newValueNbBlockColocInfo + "')")
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
		$('#divMessage-ml').css('display', 'inherit');
	}
	else {
		$('#divPhoto-ml').css('display', 'inline');
		$('#divMessage-ml').css('display', 'none');
	}
}

function openInterestedWindow_merev() {
	$('#divPhoto-ml').css('display', 'none');
	$('#divMessage-ml').css('display', 'none');
	$('#divInterestedEmail-merev').css('display', 'inherit')
	$('#divEmail-mgoi').css('display', 'block');
}

function closeWindow() {
	$('#divPhoto-ml').css('display', 'inline');
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
	openModalInThisTab();
}

function showOthersAnnounces() {
	var announce = $("#annonce2-alpv")[0].outerHTML;
	$("#divOthersAnnounces-alpv").append(announce);
	openModalInThisTab();
}

function showOthersPeople() {
	var people = $(".divPeoplesSearching:first-child")[0].outerHTML;
	$("#divPanelPl #divBtnOtherAnnonceLocation-alpv").before(people);
	openModalInThisTab();
}

function lineMaxToShow(textElement) {
	var el = $(textElement);
	var divHeight = parseInt(el.css('height'));
	var lineHeight = parseInt(el.css('line-height'));
	var lines = divHeight / lineHeight;
	el.css("-webkit-line-clamp", Math.floor(lines).toString());
}

function getOtherMarkerFromThisNewPlace(ui) {
	var locationSelected = ui.item.value;

}

function typeOfResearchLocation(item) {
	if (item.value == "communes") {
		$("#inputSearchPlace-ph").attr("placeholder", "Veuillez indiquer la commune concernée")
		$("#inputSearchPlace-ph").attr("oninput", "addr_searchCity(this);checkToDisableLstOrNot(this)")
		$("#inputSearchPlace-ph").removeAttr("disabled")
	}
	else if (item.value == "departements") {
		$("#inputSearchPlace-ph").attr("placeholder", "Veuillez indiquer le département concerné")
		$("#inputSearchPlace-ph").attr("oninput", "addr_searchDepartement(this);checkToDisableLstOrNot(this)")
		$("#inputSearchPlace-ph").removeAttr("disabled")
	}
	else if (item.value == "regions") {
		$("#inputSearchPlace-ph").attr("placeholder", "Veuillez indiquer la région concernée")
		$("#inputSearchPlace-ph").attr("oninput", "addr_searchRegion(this);checkToDisableLstOrNot(this)")
		$("#inputSearchPlace-ph").removeAttr("disabled")
	}
	else if (item.value == "france") {
		$("#inputSearchPlace-ph").attr("placeholder", "Dans toute la France")
		$("#inputSearchPlace-ph").attr("disabled", "true")
	}
	else {
		$("#inputSearchPlace-ph").attr("placeholder", "Veuillez indiquer la commune concernée")
		$("#inputSearchPlace-ph").attr("oninput", "addr_searchCity(this)")
		$("#inputSearchPlace-ph").removeAttr("disabled")
	}
}

function showPopUpInfo(iconElement, elementPopUp) {
	$(elementPopUp).fadeIn("slow");
	$(elementPopUp).attr("onmouseout", "closePopUpInfo(this)")

	$(iconElement).mouseleave(function (e) {
		setTimeout(function () {
			if ($(elementPopUp + ':hover').length == 0 && $(elementPopUp + ' scroll:hover').length == 0) {
				closePopUpInfo(elementPopUp)
			}
		}, 500);
	});
}

function closePopUpInfo(elementPopUp) {
	$(elementPopUp).fadeOut("slow");
}

function loadAccountConnexionToFinishOperation() {
	$('#div1CreateAccount-acc').remove()
	$('#divMdpForget-acc').attr('target', '_blank')
	$('#btnConnexion-acc').attr('onclick', '')
}

function triggerBtnOnOffOnAgence() {
	$("#agence-cb").click(function (e) {
		setTimeout(function () {
			if ($("#agence-cb").val() == 0) {
				$('#nomAgence-mlca').attr('disabled', 'true')
				$('#numSiret-mlca').attr('disabled', 'true')
				$('#fraisAgence-mlca').attr('disabled', 'true')

				$("#divPersonnaliteInfo-mcar").fadeIn("slow");
			}
			else {
				$('#nomAgence-mlca').removeAttr('disabled')
				$('#numSiret-mlca').removeAttr('disabled')
				$('#fraisAgence-mlca').removeAttr('disabled')

				$("#divPersonnaliteInfo-mcar").fadeOut("slow");
			}
		}, 250);
	});
}

function triggerBtnOnOffOnTerain_mpc() {
	$("#enableTerrain-mpc").click(function (e) {
		setTimeout(function () {
			if ($("#enableTerrain-mpc").val() == 0) {
				$('#select-engagementTypeTerrain-mpc').attr('disabled', 'true')
				$('#superficieTerrain-mpc').attr('disabled', 'true')
				$('#coutAchatMoyTerrain-mpc').attr('disabled', 'true')
				$('#nbParticipantAchatTerrainResearch-mpc').fadeOut("fast")

				//$("#divPersonnaliteInfo-mcar").fadeIn("slow");
			}
			else {
				$('#select-engagementTypeTerrain-mpc').removeAttr('disabled')
				$('#coutAchatMoyTerrain-mpc').removeAttr('disabled')
				$('#superficieTerrain-mpc').removeAttr('disabled')
				$('#coutAchatMoyTerrain-mpc').removeAttr('disabled')
				if ($("#select-engagementTypeTerrain-mpc").children(":selected").html() == 'Achat') {
					$('#nbParticipantAchatTerrainResearch-mpc').fadeIn("fast")
				}
			}
		}, 250);
	});
}

function initButtonOnOff() {
	for (var i = 0; i < $('.onoff input').length; i++) {
		var elementId = "#" + $('.onoff input')[i].id;
		if ($(elementId).attr('value') == '0') {
			$(elementId).click()
		}
	}

	$(".onoff input").click(function (e) {
		if ($(this).attr('value') == '0') {
			$(this).val("1")
		}
		else {
			$(this).val("0")
		}
	})
}

function updateLocalisationPeopleSearch() {
	//Change le titre selon la ville "150 personnes recherchent à ..."
	//Mettre à jour les personnes qui recherchent
}

function appearAndOpenWindowsConvDev() {
	setTimeout(function () {
		$("#divConversationDev-main").fadeIn("fast")
		setTimeout(function () {
			$("#firstImgProfilConv-main").fadeOut("fast")
			$("#secondMsgByMySelf-main").fadeIn("fast")
			$("#secondImgProfilConv-main").fadeIn("fast")
		}, 4000)
	}, 6000)
}

function appearAndReduceWindowsConvDev() {
	reduceWindowsConvDev();
	$("#divConversationDev-main").fadeIn("fast")
	$("#firstImgProfilConv-main").fadeOut("fast")
	$("#secondMsgByMySelf-main").fadeIn("fast")
	$("#secondImgProfilConv-main").fadeIn("fast")
}

function reduceOrOpenWindowsConvDev() {
	if ($("#bdArticleConvDev-main").css("display") != "none") {
		reduceWindowsConvDev();
	}
	else {
		openWindowsConvDev();
	}
}

function reduceWindowsConvDev() {
	$("#bdImgReduceConvDev-main").css("display", "none")
	$("#bdArticleConvDev-main").css("display", "none")
	$("#divFooterConDev-main").css("display", "none")
	$("#divConversationDev-main").css("height", "42px")
	$("#divConversationDev-main").css("width", "200px")
	$("#bandeauConvDev-main").css("height", "42px")
}

function openWindowsConvDev() {
	$("#divConversationDev-main").css("height", "300px")
	$("#divConversationDev-main").css("width", "235px")
	$("#bandeauConvDev-main").css("height", "14%")
	$("#bdArticleConvDev-main").fadeIn("fast")
	$("#divFooterConDev-main").fadeIn("fast")
	$("#bdImgReduceConvDev-main").fadeIn("fast")
}

function sendMsgOnConvDev() {
	//Regarder si le formulaire est valider (pour voir si le mail est bien un email)

	if ($("#inputEmailDev-main").val() != "") {
		if ($("#saisiMsgConvDev-main").val() != "") {
			var elementHtml =
				'<div class="newMessageUserConvDev-main flex">' +
				'<p class="txtUser-main">' + $("#saisiMsgConvDev-main").val() + '</p>' +
				'</div>'

			$("#divAnswerUserConDev-main").append(elementHtml);

			$("#saisiMsgConvDev-main").val("")
			$("#inputEmailDev-main").attr("disabled", "true")

			var scroolHeight = $("#bdArticleConvDev-main")[0].scrollHeight;
			$("#bdArticleConvDev-main").scrollTop(scroolHeight);
		}
		if ($(".divFileUplConvDev-main").length != 0) {
			var chiffreAleatoire = Math.floor(100000 + Math.random() * 900000);

			var elementHtml = '<div class="newMessageUserConvDev-main flex" id="newMessageUserConDev' + chiffreAleatoire + '"></div>'
			$("#divAnswerUserConDev-main").append(elementHtml);

			var classList = $(".fileUplConvDev-main");
			for (var i = 0; i < classList.length; i++) {
				debugger;
				urlImg = $(classList[i]).css('background-image');

				var elementHtml2 =
					'<div class="appearImgUplConvDev-main" style=\'background: ' + urlImg + ' 50% no-repeat;\'></div>';

				$("#newMessageUserConDev" + chiffreAleatoire).append(elementHtml2);
			};

			$(".divFileUplConvDev-main").remove();
			$("#lstFilesUploadConvDev-main").css("display", "none")
			$("#bdArticleConvDev-main").css("height", "66%")
			$("#inputEmailDev-main").attr("disabled", "true")

			var scroolHeight = $("#bdArticleConvDev-main")[0].scrollHeight;
			$("#bdArticleConvDev-main").scrollTop(scroolHeight);
		}
	}
	else {
		alert("Pour envoyer un message vous devez saisir votre email.")
	}
}

function uploadImgConvDev(filesInputId) {
	var filesInputOut = document.getElementById(filesInputId);

	filesInputOut.addEventListener("change", function (event) {

		var files = event.target.files; //FileList object

		for (var i = 0; i < files.length; i++) {
			var file = files[i];

			var picReader = new FileReader();

			picReader.addEventListener("load", function (event) {

				numberId = Math.floor(100000 + Math.random() * 900000);

				var picFile = event.target;

				var elementHtml =
					'<div class="divFileUplConvDev-main" id="divFileUplConvDev' + numberId + '">' +
					'<i class="fas fa-times-circle imgCloseFileUplConvDev-main" onclick="removePictureConvDev(\'#divFileUplConvDev' + numberId + '\')"></i>' +
					'<div style="color:white;background: url(' + picFile.result + ') 50% no-repeat;" class="fileUplConvDev-main" id="idFileUplConvDev' + numberId + '"></div>' +
					'</div>';

				$("#lstFilesUploadConvDev-main").append(elementHtml);

				if ($("#lstFilesUploadConvDev-main").css("display", "none")) {
					$("#bdArticleConvDev-main").css("height", "49%")
					$("#lstFilesUploadConvDev-main").css("display", "flex")
				}
			});

			//Read the image
			picReader.readAsDataURL(file);
		}
		$('input[type="file"]').val(null);
	});
}

function removePictureConvDev(element) {
	$(element).remove();
	if ($(".divFileUplConvDev-main").length == 0) {
		$("#lstFilesUploadConvDev-main").css("display", "none")
		$("#bdArticleConvDev-main").css("height", "66%")
	}
}

function changeEndOfDispoVisibility() {
	if ($("#dispoTemporaireChk-mlca").prop('checked')) {
		$("#divEndDispo-mlca").fadeIn("slow");
	}
	else {
		$("#divEndDispo-mlca").fadeOut("slow");
	}
}

function changeOngletInModalLocation(selectedTab) {
	if ($(selectedTab).attr("data-selected") != "true") {
		$(".ongletAnnonce-ml").css("background-color", "white")
		$(".ongletAnnonce-ml").css("color", "#888")
		$(".ongletAnnonce-ml").attr("data-selected", "false")
		$(".viewFromOnglet-ml").fadeOut("slow")

		$(selectedTab).css("background-color", "#bbc800")
		$(selectedTab).css("color", "white")
		$(selectedTab).attr("data-selected", "true")
		var idBlockToShow = $(selectedTab).attr("data-id")
		$("#" + idBlockToShow).fadeIn("slow")

		if ($(selectedTab).attr("data-showmap") == "true" && $(selectedTab).attr("data-mapisinit") == "false") {
			showModalLocationMarker_onMap();
			$(selectedTab).attr("data-mapisinit", "true");
		}
		else if ($(selectedTab).attr("data-showstreetview") == "true") {
			showStreetView();
		}
	}
}

function showModalLocationMarker_onMap() {
	var mymap = L.map('localisationMarkerOnMap-ml').setView([48.101228, -1.686257], 15);

	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}', {
		maxZoom: 18,
		id: 'mapbox.streets',
		accessToken: 'pk.eyJ1Ijoia2dhcm5pZXIiLCJhIjoiY2pyajlmOW1nMDlmNDQ5bzAwemRoNTNpeSJ9.7Evwr47aOCoVYOAnds_WZA'
	}).addTo(mymap);

	L.circle([48.101228, -1.686257], 100).addTo(mymap);
}

function showStreetView() {
	var fenway = { lat: 48.101228, lng: -1.686257 };

	var map = new google.maps.Map(document.getElementById('streetViewMap-ml'), {
		center: fenway,
		zoom: 14
	});
	var panorama = new google.maps.StreetViewPanorama(
		document.getElementById('annonceInfo-ml'), {
			position: fenway,
			pov: {
				heading: 34,
				pitch: 10
			}
		});
	map.setStreetView(panorama);
}

function checkedOrNotAccordingToTheStatus(elementId) {
	if ($(elementId).is(':checked')) {
		$(elementId).prop('checked', false);
	}
	else {
		$(elementId).prop('checked', true);
	}
}

function addNewEcologieAction(elementIdToAppend, elementInput) {
	var textWrite = $("#" + elementInput).val();

	var elementHtml = '<div class="flex">' +
		'<input class="ckboxPratice-ayer" type="checkbox" name="Permaculture" checked>' +
		'<p class="showTxt-ayer" name="' + textWrite + '">' + textWrite + '</p>' +
		'</div>';

	$("#" + elementIdToAppend).append(elementHtml);

	$("#" + elementInput).val("")
}

function initAnnonceDescResult(pageElementId) {
	var typingTimer;

	$(pageElementId + " .inpDescAnnonce").on('keyup', function (e) {
		clearTimeout(typingTimer);
		typingTimer = setTimeout(function () {
			actionInitAnnonceDescResult(pageElementId, e)
		}, 1000);
	});

	$(pageElementId + " .inpDescAnnonce").on('change', function (e) {
		actionInitAnnonceDescResult(pageElementId, e);
	})
}

function actionInitAnnonceDescResult(pageElementId, e) {
	var textElement = $(pageElementId + " #" + e.target.id).val();
	$(pageElementId + " #" + e.target.id + "Result").text(textElement);

	var isEmpty = true;
	for (var i = 0; i < $(pageElementId + " .inpDescAnnonceResult").length; i++) {
		var idElementResult = $(pageElementId + " .inpDescAnnonceResult").get(i).id;
		var textResult = $(pageElementId + " #" + idElementResult).text()

		if (textResult.length != 0) {
			isEmpty = false;
			break;
		}
	}

	if (isEmpty == true) {
		$(pageElementId + " .textShowUserDesc").fadeIn(0)
	}
	else {
		$(pageElementId + " .textShowUserDesc").fadeOut(0)
	}
}