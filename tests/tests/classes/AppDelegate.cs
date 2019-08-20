using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CocosSharp;


namespace tests
{
    public class AppDelegate : CCApplicationDelegate
    {
        public static CCWindow SharedWindow
        {
            get;
            set;
        }

        public AppDelegate()
        {

        }

        public override void ApplicationDidFinishLaunching(CCApplication application, CCWindow mainWindow)
        {
            //application.AllowUserResizing = true;
            application.PreferMultiSampling = true;
            application.ContentRootDirectory = "Content";

            application.ContentSearchResolutionOrder = new List<string>() { "", "images", "fonts" };

            var windowSize = mainWindow.WindowSizeInPixels;
            SharedWindow = mainWindow;

            var desiredWidth = 1024.0f;
            var desiredHeight = 768.0f;

            //CCSpriteFontCache.FontScale = 0.6f;
            application.SpriteFontCache.RegisterFont("arial", 12, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 38, 50, 64);
            application.SpriteFontCache.RegisterFont("MarkerFelt", 16, 18, 22, 32);
            application.SpriteFontCache.RegisterFont("MarkerFelt-Thin", 12, 18);
            application.SpriteFontCache.RegisterFont("Paint Boy", 26);
            application.SpriteFontCache.RegisterFont("Schwarzwald Regular", 26);
            application.SpriteFontCache.RegisterFont("Scissor Cuts", 26);
            application.SpriteFontCache.RegisterFont("A Damn Mess", 26);
            application.SpriteFontCache.RegisterFont("Abberancy", 26);
            application.SpriteFontCache.RegisterFont("Abduction", 26);

            mainWindow.DisplayStats = true;
            mainWindow.StatsScale = 1;

            // This will set the world bounds to be (0,0, w, h)
            // CCSceneResolutionPolicy.ShowAll will ensure that the aspect ratio is preserved
            CCScene.SetDefaultDesignResolution(desiredWidth, desiredHeight, CCSceneResolutionPolicy.ShowAll);

            // Determine whether to use the high or low def versions of our images
            // Make sure the default texel to content size ratio is set correctly
            // Of course you're free to have a finer set of image resolutions e.g (ld, hd, super-hd)
            if (desiredWidth < windowSize.Width)
            {
                application.ContentSearchPaths.Add("hd");
                CCSprite.DefaultTexelToContentSizeRatio = 2.0f;
            }
            else
            {
                application.ContentSearchPaths.Add("ld");
                CCSprite.DefaultTexelToContentSizeRatio = 1.0f;
            }

            mainWindow.DisplayStats = true;
            var scene = new CCScene(mainWindow);
            var introLayer = new TestController();
            //var introLayer = new TestingLayer();

            scene.AddChild(introLayer);

            mainWindow.RunWithScene(scene);


            base.ApplicationDidFinishLaunching(application, mainWindow);

        }

        public override void ApplicationDidEnterBackground(CCApplication application)
        {
            base.ApplicationDidEnterBackground(application);
        }

        public override void ApplicationWillEnterForeground(CCApplication application)
        {
            base.ApplicationWillEnterForeground(application);
        }
    }



    /*
    public override void ApplicationDidFinishLaunching(CCApplication application, CCWindow mainWindow)
    {

        //application.AllowUserResizing = true;
        application.PreferMultiSampling = false;
        application.ContentRootDirectory = "Content";

        application.ContentSearchResolutionOrder = new List<string>() { "", "images", "fonts" };

        sharedWindow = mainWindow;

        CCSize winSize = mainWindow.WindowSizeInPixels;
        CCScene.SetDefaultDesignResolution(winSize.Width, winSize.Height, CCSceneResolutionPolicy.ShowAll);
        //CCScene.SetDefaultDesignResolution(winSize.Width/2, winSize.Height/2, CCSceneResolutionPolicy.ShowAll);


        #if WINDOWS || WINDOWSGL || WINDOWSDX 
        //application.PreferredBackBufferWidth = 1024;
        //application.PreferredBackBufferHeight = 768;
        #elif MACOS
        //application.PreferredBackBufferWidth = 960;
        //application.PreferredBackBufferHeight = 640;
        #endif

        #if WINDOWS_PHONE8
        application.HandleMediaStateAutomatically = false; // Bug in MonoGame - https://github.com/Cocos2DXNA/cocos2d-xna/issues/325
        #endif

        //CCSpriteFontCache.FontScale = 0.6f;
        CCSpriteFontCache.RegisterFont("arial", 12, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 38, 50, 64);
        CCSpriteFontCache.RegisterFont("MarkerFelt", 16, 18, 22, 32);
        CCSpriteFontCache.RegisterFont("MarkerFelt-Thin", 12, 18);
        CCSpriteFontCache.RegisterFont("Paint Boy", 26);
        CCSpriteFontCache.RegisterFont("Schwarzwald Regular", 26);
        CCSpriteFontCache.RegisterFont("Scissor Cuts", 26);
        CCSpriteFontCache.RegisterFont("A Damn Mess", 26);
        CCSpriteFontCache.RegisterFont("Abberancy", 26);
        CCSpriteFontCache.RegisterFont("Abduction", 26);

        mainWindow.DisplayStats = true;
        mainWindow.StatsScale = 1;

        //            if (mainWindow.WindowSizeInPixels.Height > 320)
        //            {
        //                application.ContentSearchPaths.Insert(0,"HD");
        //            }
        //CCApplication.DefaultTexelToContentSizeRatio = 2f;
        CCScene scene = new CCScene(sharedWindow);
        CCLayer layer = new TestController();

        scene.AddChild(layer);
        sharedWindow.RunWithScene(scene);
    }

    public override void ApplicationDidEnterBackground(CCApplication application)
    {
        application.Paused = true;
    }

    public override void ApplicationWillEnterForeground(CCApplication application)
    {
        application.Paused = false;
    }
}*/
}