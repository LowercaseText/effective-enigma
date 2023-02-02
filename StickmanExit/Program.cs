using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace StickmanExit
{
    enum GameScreen
    {
        LOGO = 0,
        TITLE,
        GAMEPLAY,
        ENDING
    }

    public class BasicScreenManager
    {
        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            const int screenWidth = 800;
            const int screenHeight = 450;

            InitWindow(screenWidth, screenHeight, "raylib [core] example - basic screen manager");

            GameScreen currentScreen = GameScreen.LOGO;

            // TODO: Initialize all required variables and load all required data here!

            int framesCounter = 0;          // Useful to count frames

            SetTargetFPS(60);               // Set desired framerate (frames-per-second)
            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                switch (currentScreen)
                {
                    case GameScreen.LOGO:
                        {
                            // TODO: Update LOGO screen variables here!

                            framesCounter++;    // Count frames

                            // Wait for 2 seconds (120 frames) before jumping to TITLE screen
                            if (framesCounter > 120)
                            {
                                currentScreen = GameScreen.TITLE;
                            }
                        }
                        break;
                    case GameScreen.TITLE:
                        {
                            // TODO: Update TITLE screen variables here!

                            // Press enter to change to GAMEPLAY screen
                            if (IsKeyPressed(KeyboardKey.KEY_ENTER) || IsGestureDetected(Gesture.GESTURE_TAP))
                            {
                                currentScreen = GameScreen.GAMEPLAY;
                            }
                        }
                        break;
                    case GameScreen.GAMEPLAY:
                        {
                            // TODO: Update GAMEPLAY screen variables here!

                            // Press enter to change to ENDING screen
                            if (IsKeyPressed(KeyboardKey.KEY_ENTER) || IsGestureDetected(Gesture.GESTURE_TAP))
                            {
                                currentScreen = GameScreen.ENDING;
                            }
                        }
                        break;
                    case GameScreen.ENDING:
                        {
                            // TODO: Update ENDING screen variables here!

                            // Press enter to return to TITLE screen
                            if (IsKeyPressed(KeyboardKey.KEY_ENTER) || IsGestureDetected(Gesture.GESTURE_TAP))
                            {
                                currentScreen = GameScreen.TITLE;
                            }
                        }
                        break;
                    default:
                        break;
                }
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                BeginDrawing();

                ClearBackground(RAYWHITE);

                switch (currentScreen)
                {
                    case GameScreen.LOGO:
                        {
                            // TODO: Draw LOGO screen here!
                            DrawText("LOGO SCREEN", 20, 20, 40, LIGHTGRAY);
                            DrawText("WAIT for 2 SECONDS...", 290, 220, 20, GRAY);

                        }
                        break;
                    case GameScreen.TITLE:
                        {
                            // TODO: Draw TITLE screen here!
                            DrawRectangle(0, 0, screenWidth, screenHeight, GREEN);
                            DrawText("TITLE SCREEN", 20, 20, 40, DARKGREEN);
                            DrawText("PRESS ENTER or TAP to JUMP to GAMEPLAY SCREEN", 120, 220, 20, DARKGREEN);

                        }
                        break;
                    case GameScreen.GAMEPLAY:
                        {
                            // TODO: Draw GAMEPLAY screen here!
                            DrawRectangle(0, 0, screenWidth, screenHeight, PURPLE);
                            DrawText("GAMEPLAY SCREEN", 20, 20, 40, MAROON);
                            DrawText("PRESS ENTER or TAP to JUMP to ENDING SCREEN", 130, 220, 20, MAROON);

                        }
                        break;
                    case GameScreen.ENDING:
                        {
                            // TODO: Draw ENDING screen here!
                            DrawRectangle(0, 0, screenWidth, screenHeight, BLUE);
                            DrawText("ENDING SCREEN", 20, 20, 40, DARKBLUE);
                            DrawText("PRESS ENTER or TAP to RETURN to TITLE SCREEN", 120, 220, 20, DARKBLUE);

                        }
                        break;
                    default:
                        break;
                }

                EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------

            // TODO: Unload all loaded data (textures, fonts, audio) here!

            CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}