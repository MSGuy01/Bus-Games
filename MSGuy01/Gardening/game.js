const canvasobj = document.getElementsByTagName("canvas")[0];
console.log(canvasobj);
var ctx = canvasobj.getContext('2d');
ctx.fillStyle = 'red';
ctx.stroke();
ctx.rect(10, 10, 10, 10);
/*var image = new Image();
image.src = "flower.png";
var spriteWidth = 350,
spriteHeight = 170,
pixelsLeft = 170,
pixelsTop = 10,
canvasPosX = 20,
canvasPosY = 20;
ctx.drawImage(image, pixelsLeft, pixelsTop, spriteWidth, spriteHeight, canvasPosX, canvasPosY, spriteWidth, spriteHeight);
let i = 0;
function Draw() {
    i++;
    ctx.fillStyle = 'red';
    ctx.rect(10, 10, 10, 10);
}
window.setInterval(Draw, 1);*/