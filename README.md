# How to use

Per far partire il progetto installare le dipendenze con `dotnet restore` e poi usare `dotnet watch`.

IMPORTANTE: Se si sta usando una piattaforma Linux potrebbe essere necessario aggiungere delle dipendenze con il comando `dotnet add package SkiaSharp.NativeAssets.Linux.NoDependencies`.


Se si vuole generare direttamente il file PDF invece che usare il previewer, rimuovere i commenti in riga 1 e 6 dal file `Program.cs`.