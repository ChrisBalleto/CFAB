// $(document).ready(function(){
//   $('#CHANGETHISTOWHATEVERTHEBUTTONISPLEASE').on('click', function(){
//       var apiURL = getURL();
//     $.ajax({
//       url:apiURL,
//       dataType: 'jsonp',//this needs to be added to my ajax request when i have cross origin issues
//       success: function(places){
//         console.log(places);
//         displaySongNames(places);
//       },
//     });
//   });
// });

//chatty will require two api calls and a join to create a list to display
function getUrlChattyCoffee(isChatty){
  if(isChatty == true)
    return 'explore?section=coffee&near=milwaukee';
  else
    {return " ";}
}
function getUrlIsChattyDrink(isChatty){
  if(isChatty == true)
    return 'explore?section=drink&near=milwaukee';
  else{return " ";}
}
//need to figure out how to determine
function getUrlActive(isActive){
  if(isActive == true)
    return 'url';
  else
    {return " ";}
}
//need to figure out how to determine
function getUrlArtsy(isArtsy){
  if(isArtsy == true)
    return 'url';
  else
    {return " ";}
}
function getUrlKeyword(keyword){
  if(keyword == "chill")
    return 'explore?near=Milwaukee&query=chill';
  if(keyword == "romantic")
    return 'explore?near=Milwaukee&query=romantic';
  if(keyword == "high energy")
    return 'explore?near=Milwaukee&query=high+energy';
  else{return " ";}
}
function addFoodSection(){
  return 'section=food&';
}
function addDrinksSection(){
  return 'section=drinks&';
}
function addCoffeeSection(){
  return 'section=coffee';
}
function getFoodURL(resturantAnswer){//to be used in further filters
  if(resturantAnswer == "yes")
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
// function filterByMenu(resturantAnswer, resultArray){
//   if(resturantAnswer == "yes"){
//     return resultsArray.filter(function({
//
//     });
//   )
//   }
//
// }
