# uqac-patron-tp1
Utiliser notre librairie : 




Réponses aux questions : 
1 - Est-ce que le patron Singleton s’applique à votre système de tâches? Si oui, pouvez vous citer une solution qui n’utilisera pas ce dernier ?
Oui, ce patron s'applique sur notre système de tâches, car il faut que notre CommandExecutor soit global.
Il faut que le CommandExecutor gère les threads de manière globale et unique.
On pourrai utiliser l'injection de dépendance.
2- 