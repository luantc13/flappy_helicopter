using System;
using System.Collections.Generic;
using System.Linq;
using CocosSharp;
using FlappyHelicopter.Interfaces;
using FlappyHelicopter.Models;
using FlappyHelicopter.Repositories;

namespace FlappyHelicopter
{
    public class GameOverLayer : CCLayerColor
    {
        CCLabel scoreLabel;
        public IScoreRepository scoreRepository;

        public GameOverLayer(int score) : base(CCColor4B.Black)
        {
            scoreRepository = new ScoreRepository();

            scoreLabel = new CCLabel(String.Format("Your Score: {0}", score), "Arial", 40, CCLabelFormat.SystemFont);
            scoreLabel.Color = CCColor3B.White;

            scoreRepository.Insert(new Score { Value = score, DateCreated = DateTime.UtcNow });

            AddChild(scoreLabel);
        }

        protected override void AddedToScene()
        {
            base.AddedToScene();

            var background = new CCSprite("textGameOver");
            background.Position = new CCPoint(ContentSize.Width / 2,
                                              ContentSize.Height / (float)1.5);
            AddChild(background);
            scoreLabel.Position = new CCPoint(ContentSize.Width / 2,
                                              ContentSize.Height / (float)1.5 + background.ContentSize.Height);

            var startLabel = new CCLabel("Tap to start a new game", "Arial", 40, CCLabelFormat.SystemFont);
            startLabel.Color = CCColor3B.White;
            startLabel.Position = new CCPoint(ContentSize.Width / 2,
                                              ContentSize.Height / (float)1.5 - background.ContentSize.Height);
            AddChild(startLabel);

            // high score
            var scores = scoreRepository.Gets().ToList();
            var highScoreTitle = new CCLabel("High Score", "Arial", 40, CCLabelFormat.SystemFont);
            highScoreTitle.Color = CCColor3B.Yellow;
            highScoreTitle.Position = new CCPoint(ContentSize.Width / 2,
                                                  ContentSize.Height / (float)1.8 - background.ContentSize.Height - startLabel.ContentSize.Height);
            AddChild(highScoreTitle);

            for (int i = 0; i < scores.Count; i++)
            {
                var scoreTitle = new CCLabel((i + 1) + ".    " + scores[i].Value + "    " + scores[i].DateCreated.ToShortDateString(),
                                                "Arial", 40, CCLabelFormat.SystemFont);
                scoreTitle.Color = CCColor3B.White;
                scoreTitle.Position = new CCPoint(ContentSize.Width / 2,
                                                  ContentSize.Height / (float)1.8 - background.ContentSize.Height - startLabel.ContentSize.Height - (scoreLabel.ContentSize.Height * (i + 1)));
                AddChild(scoreTitle);
            }

            // Register for touch events
            var touchListener = new CCEventListenerTouchAllAtOnce();
            touchListener.OnTouchesBegan = OnTouchesBegan;
            AddEventListener(touchListener, this);
        }

        private void OnTouchesBegan(List<CCTouch> touches, CCEvent touchEvent)
        {
            if (touches.Count > 0)
            {
                CCScene newGameScene = new CCScene(GameView);
                var transitionToNewGame = new CCTransitionProgressInOut(0.7f, newGameScene);
                newGameScene.AddLayer(new GameLayer());
                Director.ReplaceScene(transitionToNewGame);
            }
        }
    }
}
