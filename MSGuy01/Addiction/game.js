let l = 0;
let score = 0;
let lives = 3;
let max = 0;
let background = 1;
let images = document.getElementsByClassName("MSGuy01");
if (!localStorage.getItem("money")) {
    localStorage.setItem("money", 0);
}
if (!localStorage.getItem("highScore")) {
    localStorage.setItem("highScore", 0);
}
highScoreEl.innerHTML = "High Score: " + localStorage.getItem("highScore");
scoreEl.innerHTML = "Score: " + score + " | Lives: " + lives + " | Money: " + localStorage.getItem("money");
window.setInterval(function() {
    for (let i = 0; i < images.length; i++) {
        console.log(l);
        images[i].style.left = Math.floor(Math.random() * 1000) + "px";
        images[i].style.top = Math.floor(Math.random() * 450) + "px";
    }
    if (score < 15) {
        max = score * 100;
    }
    else {
        max = 1400;
    }
}, Math.floor((Math.random() * (1500-max)) + (500 - (max/3))));

for (let i = 0; i < images.length; i++) {
    images[i].addEventListener("click", function() {
        window.setTimeout(function() {
            /*window.setInterval(function() {
                console.log('fiaewoewaf');
                images[i].style.height -= 10;
                images[i].style.width -= 10;
            }, 100);*/
            images[i].style.left = Math.floor(Math.random() * 1000) + "px";
            images[i].style.top = Math.floor(Math.random() * 450) + "px";
            localStorage.setItem("money", parseInt(localStorage.getItem("money")) + score);
            score++;
            /*if (score%10==0) {
                let newImage = document.createElement("div");
                newImage.className == "MSGuy01";
                document.body.appendChild(MSGuy01);
            }*/
            scoreEl.innerHTML = "Score: " + score + " | Lives: " + lives + " | Money: " + localStorage.getItem("money");
        }, 5);
    })
}
function reload() {
    window.location.reload();
}
document.addEventListener("keydown", function(e) {
    if (e.keyCode == 32) {
        reload();
    }
    if (e.keyCode == 66) {
        if (background == 1) {
            background = 2;
            document.body.style.backgroundImage = "url(background2.jpg)";
        }
        else {
            background = 1;
            document.body.style.backgroundImage = "url(rickroll.png)";
        }
    }
});
document.addEventListener("click", function() {
    let cScore = score;
    window.setTimeout(function() {
        if (score == cScore) {
            console.log(cScore);
            console.log(score);
            lives--;
            if (lives == 0) {
                if (parseInt(localStorage.getItem("highScore")) < score) {
                    localStorage.setItem("highScore", score);
                }
                highScoreEl.innerHTML = "High Score: " + localStorage.getItem("highScore");
                document.body.innerHTML = "YOU SUCK LMFAO<br><button onclick='reload()'>PLAY AGAIN</button>";
            }
            scoreEl.innerHTML = "Score: " + score + " | Lives: " + lives + " | Money: " + localStorage.getItem("money");
        }
    }, 5);
})
