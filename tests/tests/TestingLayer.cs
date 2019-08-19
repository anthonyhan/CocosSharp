using System;
using CocosSharp;

namespace tests
{
    public class TestingLayer : CCLayer
    {
        public TestingLayer()
        {
            //var layer = new CCLayerColor(CCColor4B.Blue);
            //AddChild(layer);

            //var sp_grossini = new CCSprite("Images/grossini");

        }

        public override void OnEnter()
        {
            string path = "Images/grossini";
            var tex2d = CCContentManager.SharedContentManager.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(path);
            var cctex = new CCTexture2D(tex2d);
            var sp = new CCSprite(cctex);
            sp.Position = Window.WindowSizeInPixels.Center;
            AddChild(sp);
            base.OnEnter();
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        public virtual string Title()
        {
            return "";
        }

        public virtual string Subtitle()
        {
            return "";
        }

        public virtual void RestartCallback(Object pSender)
        {
            CCLog.Log("override restart!");
        }

        public virtual void NextCallback(Object pSender)
        {
            CCLog.Log("override next!");
        }

        public virtual void BackCallback(Object pSender)
        {
            CCLog.Log("override back!");
        }

        protected override void AddedToScene()
        {
            base.AddedToScene();
            //CCRect bounds = VisibleBoundsWorldspace;

            //var node = new CCDrawNode();
            //node.DrawSolidCircle(new CCPoint(50, 50), 50, CCColor4B.Red);
            //node.DrawSolidCircle(new CCPoint(50, 75), 10, CCColor4B.White);
            //node.Position = bounds.Center;
            //AddChild(node);

            //var particles = new CCParticleFireworks(new CCPoint(50, 75));
            //particles.PositionType = CCPositionType.Free;
            //node.AddChild(particles);

            //node.RunAction(new CCRepeatForever( new CCRotateBy(4, 360)));
        }
    }
}