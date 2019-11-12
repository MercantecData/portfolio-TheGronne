function ChangeTheButtonTekst()
{
    document.getElementById('ChangeTekstButton').innerHTML = "Det her er en test!";
}
function destroyMe()
{
    document.getElementById('MyPicture').style.display = 'none';
}
function reviveMe()
{
    document.getElementById('MyPicture').style.display = 'block';
}
var array = ["HEY! :D", "YO"]
function addText()
{
    document.getElementById('addText').innerText = array[0]
}
function removeText()
{
    document.getElementById('addText').innerText = array[1]
}
function checkTextField()
{
    if (document.getElementById('textField').value == "YO"){
        document.getElementById('textFieldButton').innerText = array[0];
    } else {
        document.getElementById('textFieldButton').innerText = "BYE! :C";
    }
}