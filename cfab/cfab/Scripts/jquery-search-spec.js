describe('function getUrlChattyCoffee', function(){
  it('UrL return', function(){
    var isChatty = true;
    var urlSegment = 'explore?section=coffee&near=milwaukee';
    expect(getUrlChattyCoffee(isChatty)).toEqual(urlSegment);
  });
  it('Url return', function(){
    var isNotChatty = false;
    var urlSegment = " ";
    expect(getUrlChattyCoffee(isNotChatty)).toEqual(urlSegment);
  });
});
describe('function getUrlIsChattyDrink', function(){
  it('UrL return', function(){
    var isChatty = true;
    var urlSegment = 'explore?section=drink&near=milwaukee';
    expect(getUrlIsChattyDrink(isChatty)).toEqual(urlSegment);
  });
  it('Url return', function(){
    var isNotChatty = false;
    var urlSegment = " ";
    expect(getUrlIsChattyDrink(isNotChatty)).toEqual(urlSegment);
  });
});
describe('function getUrlKeyword', function(){
  it('Url return', function(){
    var keyword = "chill";
    var urlSegment = 'explore?near=Milwaukee&query=chill';
    expect(getUrlKeyword(keyword)).toEqual(urlSegment);
  });
  it('Url return', function(){
    var keyword = "romantic";
    var urlSegment = 'explore?near=Milwaukee&query=romantic';
    expect(getUrlKeyword(keyword)).toEqual(urlSegment);
  });
  it('Url return', function(){
    var keyword = "high energy";
    var urlSegment = 'explore?near=Milwaukee&query=high+energy';
    expect(getUrlKeyword(keyword)).toEqual(urlSegment);
  });
});
