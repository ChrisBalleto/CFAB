$(document).ready(function(){
  $('#CHANGETHISTOWHATEVERTHEBUTTONISPLEASE').on('click', function(){
      var apiURL = getURL();
    $.ajax({
      url:apiURL,
      dataType: 'jsonp',//this needs to be added to my ajax request when i have cross origin issues
      success: function(places){
        console.log(places);
        displaySongNames(places);
      },
    });
  });
});

function getFilteredURL(isChatty, isActive, isArtsy, keyWord){

}
function getFoodURL(){//to be used in further filters
  return 'https://api.foursquare.com/v2/venues/explore?near=milwaukee&section=food&client_id=1Y32SY1QBKL3UNRRDO5HFGXEBVT40DMQBCRZE0MUATAJNQMK&client_secret=UE3VNOOO30ZHVUCXKMFPDJZUYQZOM4XI0JTUH5CJQZDUG5QS&v=20170127';
}

function getFourSquareAPI(){
  return 'https://api.foursquare.com/v2/';
}
function getClientId(){
  return '&client_id=1Y32SY1QBKL3UNRRDO5HFGXEBVT40DMQBCRZE0MUATAJNQMK';
}
function getClientSecret(){
  return '&client_secret=UE3VNOOO30ZHVUCXKMFPDJZUYQZOM4XI0JTUH5CJQZDUG5QS';
}
function getVDate(){
  return '&v=20170127';
}
