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

function GetFourSquareAPI(){
  return 'https://api.foursquare.com/v2/';
}
function GetClientId(){
  return '&client_id=1Y32SY1QBKL3UNRRDO5HFGXEBVT40DMQBCRZE0MUATAJNQMK';
}
function GetClientSecret(){
  return '&client_secret=UE3VNOOO30ZHVUCXKMFPDJZUYQZOM4XI0JTUH5CJQZDUG5QS';
}
function GetLocation(){
  return 'explore?near=milwaukee&';
}
function GetVDate(dayOfdate){
  var dayOftheYear = dayOfdate.toString();
  var identifyPosition = dayOftheYear.lastIndexOf("/");
  var yearToUse = dayOftheYear.substr(identifyPosition+1);
  var dayOfMonth = dayOftheYear.substr(identifyPosition - 2, 2);
  var resultsOfCheck = CheckMonth(dayOftheYear);
  var month = resultsOfCheck.substr(0,2);
  return '&v='+ yearToUse + month + dayOfMonth ;
}
function CheckMonth(dayOfTheYear)
{
  if (dayOfTheYear.length != 10){
    var zero = "0";
    return zero.concat(dayOfTheYear);
  }
  else
    return dayOfTheYear;
}
function RemoveSpaces(chainedURL){
  return chainedURL.replace(/\s/g,'');
}
function GetFoodSection(){
  return 'section=food&';
}
function GetUrlChatty(isChatty){
  if(isChatty == true)
    return 'section=coffee&section=drink&';
}
function GetUrlActive(isActive){
  if(isActive == true)
    return 'section=outdoors';
}
function GetUrlArtsy(isArtsy){
  if(isArtsy == true)
    return 'section=arts';
}
function GetUrlKeyword(keyword){
  if(keyword == "chill")
    return 'query=chill&';
  if(keyword == "romantic")
    return 'query=romantic&';
  if(keyword == "high energy")
    return 'query=lively&';
  else{return " ";}
}
function GetPrice(dateCost){
  if(dateCost == 1)
    return 'price=1&';
  else if(dateCost == 2)
    return 'price=2&';
  else if(dateCost == 3)
    return 'price=3&';
  else if(dateCost == 4)
    return 'price=4&';
}
function FilterByMenu(resturantAnswer, jsonResult){
  if(resturantAnswer == true){
    var newarray= jsonResult.response.groups["0"].items.filter(function(place){
      if(place.venue.hasMenu == true || place.venue.hasMenu == undefined);
      return place.venue;
    });
    return newarray;
  }
}
function GenerateURL(chatty=false,active=false,artsy=false,isEating=false,queryWord=" ",priceRange,vDate){
  var mainApiRequest = GetFourSquareAPI();
  var exploreSearch = GetLocation();
  var fsClientId = GetClientId();
  var fsSecretId = GetClientSecret();
  var apiAndExploreUrl = AppendURL(mainApiRequest,exploreSearch);
  var apiWithDescriptionUrl = AppendUrlWithDescription(chatty,active,artsy,apiAndExploreUrl);
  var apiDescriptionandFoodUrl = AppendUrlWithResturant(isEating,apiWithDescriptionUrl);
  var apiWithKeyword = AppendUrlWithKeyword(queryWord, apiDescriptionandFoodUrl);
  var apiUrlWithPrice = AppendUrlWithPrice(priceRange, apiWithKeyword);
  var apiUrlWithVdate = AppendUrlWithVdate(vDate,AppendUrlWithPrice);
  return RemoveSpaces(apiUrlWithVdate);
}
function AppendURL(urlToChange, partOfUrlToAdd){
  return urlToChange.concat(partOfUrlToAdd);
}
function AppendUrlWithDescription(responseForChatty, responseForActive,responseForArtsy,urlToAppend){
  if(responseForChatty==true){
    return urlToAppend.concat(GetUrlChatty(responseForChatty));
  }
  else if(responseForActive==true){
    return urlToAppend.concat(GetUrlActive(responseForActive));
  }
  else if(responseForArtsy==true){
    return urlToAppend.concat(GetUrlArtsy(responseForArtsy));
  }
}
function AppendUrlWithResturant(responseForEating,urlToAppend){
  if(responseForEating == true)
    return urlToAppend.concat(GetFoodSection(responseForEating));
  else
    return urlToAppend;
}
function AppendUrlWithKeyword(keywordResponse,urlToAppend){
  return urlToAppend.concat(GetUrlKeyword(keywordResponse));
}
function AppendUrlWithPrice(priceSelection,urlToAppend)
{
  return urlToAppend.concat(GetPrice(priceSelection));
}
function AppendUrlWithVdate(vDate, urlToAppend){
  var vDateUrl = GetVDate(vDate);
  return urlToAppend.concat(vDateUrl);
}
