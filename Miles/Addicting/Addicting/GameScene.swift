//
//  GameScene.swift
//  Addicting
//

import SpriteKit
import GameplayKit
class GameScene: SKScene {
    var counting = 0
    var upgradeButton = SKLabelNode(text: "upgrade")
    var scoreButton = SKLabelNode(text: "Score: 0")
    var score = 0
    var circleSize = 50
    var countSpeed = 60
    override func didMove(to view: SKView) {
        upgradeButton.name = "upgradeButton"
        upgradeButton.fontSize = 100
        upgradeButton.position = CGPoint(x: 0, y: self.size.height/3)
        addChild(upgradeButton)
        scoreButton.name = "scoreButton"
        scoreButton.fontSize = 50
        scoreButton.position = CGPoint(x: 0, y: upgradeButton.position.y - 100)
        addChild(scoreButton)
    }
    override func touchesBegan(_ touches: Set<UITouch>, with event: UIEvent?) {
        let touch = touches.first
        let pos = touch?.location(in: self) ?? CGPoint(x:0, y:0)
        let nodes = nodes(at: pos)
        for node in nodes {
            if node.name == "upgradeButton" {
                if score >= 25 {
                    score -= 25
                    countSpeed = countSpeed * 4 / 5
                    if countSpeed < 1 {
                        countSpeed = 1
                    }
                    counting = 0
                    print(countSpeed)
                    scoreButton.text = "Score:\(score)"
                    circleSize = circleSize * 3 / 4
                    if circleSize < 10 {
                        circleSize = 10
                    }
                }
            } else if node.name == "circle" {
                node.removeFromParent()
                score += 1
                scoreButton.text = "Score:\(score)"
            }
        }
    }
    override func touchesMoved(_ touches: Set<UITouch>, with event: UIEvent?) {
        let touch = touches.first
        let pos = touch?.location(in: self) ?? CGPoint(x:0, y:0)
        let nodes = nodes(at: pos)
        for node in nodes {
            if node.name == "circle" {
                node.removeFromParent()
                score += 1
                scoreButton.text = "Score:\(score)"
            }
        }
    }
    func spawnCircle() {
        let randomX = Int.random(in: Int(self.size.width / -2 + 15)...Int(self.size.width / 2 - 15))
        let colorArray = [SKColor.red, SKColor.orange, SKColor.yellow, SKColor.green, SKColor.blue, SKColor.purple]
        let newCircle = SKShapeNode(circleOfRadius: CGFloat(circleSize))
        newCircle.name = "circle"
        newCircle.strokeColor = .clear
        newCircle.fillColor = colorArray.randomElement() ?? SKColor.red
        newCircle.position = CGPoint(x: randomX, y: Int(self.size.height)/2)
        newCircle.physicsBody = SKPhysicsBody(circleOfRadius: CGFloat(circleSize))
        addChild(newCircle)
    }
    override func update(_ currentTime: TimeInterval) {
        counting += 1
        if counting == countSpeed {
            counting = 0
            spawnCircle()
        }
    }
}
