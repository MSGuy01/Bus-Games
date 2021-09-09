const canvas = document.getElementsByTagName("canvas")[0];
const ctx = canvas.getContext('2d');
let image = new Image();
image.src = "player.png"
ctx.drawImage(image, 0, 0, 200, 100, 1, 1, 200, 100)
let i = 0;
function Draw() {
    i++;
    ctx.fillStyle = 'red';
    ctx.ellipse(i, i, i, i, 0, 0, 0, false);
}
window.setInterval(Draw, 1);