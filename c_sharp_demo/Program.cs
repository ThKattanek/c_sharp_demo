using System;
using SDL2;
using SDL2.Bindings;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

var window = SDL.SDL_CreateWindow("DEMO",
	SDL.SDL_WINDOWPOS_CENTERED,
	SDL.SDL_WINDOWPOS_CENTERED,
	800,
	600,
	SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN
	);

	while(true);