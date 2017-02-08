// $(document).ready(function(){
//   $('#CHANGETHISTOWHATEVERTHEBUTTONISPLEASE').on('click', function(){
//       //var apiURL = getURL();
//       var apiURL = 'https://api.foursquare.com/v2/venues/explore?near=milwaukee&query=romantic&price=1,2&client_id=1Y32SY1QBKL3UNRRDO5HFGXEBVT40DMQBCRZE0MUATAJNQMK&client_secret=UE3VNOOO30ZHVUCXKMFPDJZUYQZOM4XI0JTUH5CJQZDUG5QS&v=20170127';
//       dataType: 'jsonp',//this needs to be added to my ajax request when i have cross origin issues;
//     $.ajax({
//       url:apiURL,
//       dataType: 'jsonp',//this needs to be added to my ajax request when i have cross origin issues
//       success: function(places){
//         $json_results = json_decode(places,true);
//         console.log($json_results);
//       },
//     });
//   });
// });

function getFourSquareAPI(){
  return 'https://api.foursquare.com/v2/';
}
function getClientId(){
  return '&client_id=1Y32SY1QBKL3UNRRDO5HFGXEBVT40DMQBCRZE0MUATAJNQMK';
}
function getClientSecret(){
  return '&client_secret=UE3VNOOO30ZHVUCXKMFPDJZUYQZOM4XI0JTUH5CJQZDUG5QS';
}
function getLocation(){
  return 'explore?near=milwaukee&';
}
function getVDate(dayOfTheYear){
  var identifyPosition = dayOfTheYear.lastIndexOf("/");
  var yearToUse = dayOfTheYear.substr(identifyPosition+1);
  var dayOfMonth = dayOfTheYear.substr(identifyPosition - 2, 2);
  var resultsOfCheck = checkMonth(dayOfTheYear);
  var month = resultsOfCheck.substr(0,2);
  return '&v='+ yearToUse + month + dayOfMonth ;  //20170127
}
function checkMonth(dayOfTheYear)
{
  if (dayOfTheYear.length != 10){
    var zero = "0";
    return zero.concat(dayOfTheYear);
  }
  else
    return dayOfTheYear;
}
function removeSpaces(chainedURL){
  return chainedURL.replace(/\s/g,'');
}
function addFoodSection(){
  return 'section=food&';
}
function addDrinksSection(){
  return 'section=drinks&';
}
function addCoffeeSection(){
  return 'section=coffee&';
}
function getFoodURL(resturantAnswer){//to be used in further filters
  if(resturantAnswer == "true")
    return 'https://api.foursquare.com/v2/venues/explore?near=milwaukee&section=food&client_id=1Y32SY1QBKL3UNRRDO5HFGXEBVT40DMQBCRZE0MUATAJNQMK&client_secret=UE3VNOOO30ZHVUCXKMFPDJZUYQZOM4XI0JTUH5CJQZDUG5QS&v=20170127';
}
// function concatSearchResults(firstResultSet, secondResultSet, thirdResultsSet=[], fourthResultsSet=[], fifthResultsSet=[]){
//   return firstResultSet.concat(secondResultSet);
// }
//chatty will require two api calls and a join to create a list to display
function getUrlChattyCoffee(isChatty){
  if(isChatty == true)
    return 'section=coffee&';
  else
    {return " ";}
}
function getUrlIsChattyDrink(isChatty){
  if(isChatty == true)
    return 'section=drink&';
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
    return 'query=chill&';
  if(keyword == "romantic")
    return 'query=romantic&';
  if(keyword == "high energy")
    return 'query=lively&';
  else{return " ";}
}
function getPrice(dateCost){
  if(dateCost == 1)
    return 'price=1&';
  else if(dateCost == 2)
    return 'price=2&';
  else if(dateCost == 3)
    return 'price=3&';
  else if(dateCost == 4)
    return 'price=4&';
}
function filterByMenu(resturantAnswer, jsonResult){
  if(resturantAnswer == true){
    var newarray= jsonResult.response.groups["0"].items.filter(function(place){
      if(place.venue.hasMenu == true || place.venue.hasMenu == undefined);
      return place.venue;
    });
    return newarray;
  }
}
function generateURL(chatty=false,active=false,artsy=false,isEating=false,vDate,queryWord,priceRange){
  var mainApiRequest = getFourSquareAPI();
  var exploreSearch = getLocation();
  var fsClientId = getClientId();
  var fsSecretId = getClientSecret();
}
