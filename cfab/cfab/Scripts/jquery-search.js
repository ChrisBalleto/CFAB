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
  return 'client_id=1Y32SY1QBKL3UNRRDO5HFGXEBVT40DMQBCRZE0MUATAJNQMK&';
}
function GetClientSecret(){
  return 'client_secret=UE3VNOOO30ZHVUCXKMFPDJZUYQZOM4XI0JTUH5CJQZDUG5QS&';
}
function GetLocation(){
  return 'explore?near=milwaukee&';
}
function GetVDate(dayOftheYear){
  //var dateSubstring = dayOfdate.substr(0,10);
  //var dayOftheYear = dateSubstring.trim(" ");
  var identifyPosition = dayOftheYear.lastIndexOf("/");
  var yearToUse = dayOftheYear.substr(identifyPosition+1);
  var dayOfMonth = dayOftheYear.substr(identifyPosition - 2, 2);
  var resultsOfCheck = CheckMonth(dayOftheYear);
  var month = resultsOfCheck.substr(0,2);
  return 'v='+ yearToUse + month + dayOfMonth ;
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
  if(isChatty == 1)
    return 'section=coffee&section=drinks&';
}
function GetUrlActive(isActive){
  if(isActive == 2)
    return 'section=outdoors&';
}
function GetUrlArtsy(isArtsy){
  if(isArtsy == 3)
    return 'section=arts&';
}
function GetUrlKeyword(keyword){
  if(keyword == "chill")
    return 'query=chill&';
  if(keyword == "romantic")
    return 'query=romantic&';
  if(keyword == "high energy")
    return 'query=lively&';
  else{return "";}
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
function GenerateURL(response,isEating=false,queryWord=" ",priceRange,vDate){
  var mainApiRequest = GetFourSquareAPI();
  var exploreSearch = GetLocation();
  var fsClientId = GetClientId();
  var fsSecretId = GetClientSecret();
  var apiAndExploreUrl = AppendURL(mainApiRequest,exploreSearch);
  var apiWithDescriptionUrl = AppendUrlWithDescription(response,apiAndExploreUrl);
  var apiDescriptionandFoodUrl = AppendUrlWithResturant(isEating,apiWithDescriptionUrl);
  var apiWithKeyword = AppendUrlWithKeyword(queryWord, apiDescriptionandFoodUrl);
  var apiUrlWithPrice = AppendUrlWithPrice(priceRange, apiWithKeyword);
  var apiUrlWithClientId = AppendUrlWithClientId(apiUrlWithPrice,fsClientId);
  var apiUrlWithSecretId = AppendUrlWithSecretId(apiUrlWithClientId,fsSecretId);
  var apiUrlWithVdate = AppendUrlWithVdate(vDate,apiUrlWithSecretId);
  return RemoveSpaces(apiUrlWithVdate);
}
function AppendURL(urlToChange, partOfUrlToAdd){
  return urlToChange.concat(partOfUrlToAdd);
}
function AppendUrlWithDescription(response, urlToAppend){
  if(response==1){
    return urlToAppend.concat(GetUrlChatty(response));
  }
  else if(response==2){
    return urlToAppend.concat(GetUrlActive(response));
  }
  else if(response==3){
    return urlToAppend.concat(GetUrlArtsy(response));
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
function AppendUrlWithClientId(urlToAppend,clientId){
  return urlToAppend.concat(clientId);
}
function AppendUrlWithSecretId(urlToAppend,secretId){
  return urlToAppend.concat(secretId);
}
function AppendUrlWithVdate(vDate, urlToAppend){
  var vDateUrl = GetVDate(vDate);
  return urlToAppend.concat(vDateUrl);
}
