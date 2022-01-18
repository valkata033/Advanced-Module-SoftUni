﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] inputInfo = input.Split();
                string trainerName = inputInfo[0];
                string pokemonName = inputInfo[1];
                string element = inputInfo[2];
                int health = int.Parse(inputInfo[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer newTrainer = new Trainer(trainerName);

                    trainers.Add(trainerName, newTrainer);
                }

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                Trainer trainer = trainers[trainerName];
                trainer.Pokemons.Add(pokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.Value.Badges += 1;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
