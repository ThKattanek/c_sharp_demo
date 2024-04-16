using System;
using SDL2;
using SDL2.Bindings;

namespace sdl
{
	class Program
	{
		static void Main(string[] args)
		{
			SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

			var window = SDL.SDL_CreateWindow("DEMO",
			SDL.SDL_WINDOWPOS_CENTERED,
			SDL.SDL_WINDOWPOS_CENTERED,
			800,
			600,
			SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN
			);

			var renderer = SDL.SDL_CreateRenderer(window, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);

			SDL.SDL_SetRenderDrawColor(renderer, 135, 200, 235, 255);
			SDL.SDL_RenderClear(renderer);
			SDL.SDL_RenderPresent(renderer);

			bool running = true;

			while(running)
			{
				while(SDL.SDL_PollEvent(out SDL.SDL_Event e) == 1)
				{
					if(e.type == SDL.SDL_EventType.SDL_QUIT) 
						running = false;
				}
			}

			SDL.SDL_DestroyRenderer(renderer);
			SDL.SDL_DestroyWindow(window);
			SDL.SDL_Quit();
		}
	}
}

