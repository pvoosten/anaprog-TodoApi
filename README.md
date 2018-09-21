# anaprog-TodoApi

 ## stap 2 - Voeg een unit test project toe

  + rechts klikken op de solution in Solution Explorer
  + **Add > New project...**
  + In het dialoogvenster *Add new project*
     + Onder **Installed > Visual C# > Test**, kies *MsTest Test Project (.NET Core)*
     + Name: TodoTests
     + Klik OK

Het testproject *TodoTests* wordt toegevoegd aan de solution *TodoApi*.

Voeg nu in *TodoTests* een dependency naar het project *TodoObjectModel* toe. Doe daarvoor het volgende in *Solution Explorer*:

 + In het project *TodoTests* rechts klikken op *Dependencies*
 + **Add Reference...**
 + In *Reference manager - TodoTests*
    + Vink *TodoObjectModel* aan
    + Klik op OK
