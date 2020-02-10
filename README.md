# uqac-patron-tp1
Utiliser notre librairie : 

nom de librairie : ServerToServerCommunication
utilisation : créer une variable apiBuilder
les parametres peuvent etre : 	setThread(int nb thread)
				setHttp() pour une communication http
				setConsole() pour une communiction console
				setCompression() et setEncrypted() respectivement pour la compression et l'encryption
note : les protocoles doivent etre set avant les flux, un seul protocole n'est disponible par instance d'api. il n'y a pas de limite aux proprietes de flux.
utiliset GetResult() pour retouner un objet api avec les parametres precedement definis
la commande SendCommand permet d'envoyer les commandes definis par la librairie
actuellement la commande "hello" affiche le message "hello ..." avec comme fin de message le deuxieme parametre de la commande
NB si le programme fini avant les threads, le resultat des threads n'apparait pas. 


Réponses aux questions : 
1 - Est-ce que le patron Singleton s’applique à votre système de tâches? Si oui, pouvez vous citer une solution qui n’utilisera pas ce dernier ?
Oui, ce patron s'applique sur notre système de tâches, car il faut que notre CommandExecutor soit global.
Il faut que le CommandExecutor gère les threads de manière globale et unique.
On pourrai utiliser l'injection de dépendance.
2-Quel patron va-vous aider à construire des flux basés sur un protocole tout en gardant toujours la même interface?
Le patron nous aidant à construire ces flux est le Factory.
3-Quel patron utiliser pour composer les flux afin de créer des flux chiffrés et compressés?
Le patron à utiliser pour composer les flux chiffrés et compressés est le decorateur.
4-Est-ce que votre instance de protocole de communication devrait être un flux? Pourquoi?
Non, il n'est pas forcément un flux, ce n'est pas nécessaire mais possible. 
Le protocole de communication peut être une propriété du flux ou un flux à part entière.
5-Quel patron va-vous permettre de construire votre instance en permettant de facilement ajouter des paramètres de construction plus tard?
Le patron nous permettant de construire notre instance en permettant de facilement ajotuer des paramètres de construction plus tard est le builder.
6-Est-ce que cette instance de classe devrait être un singleton? Pourquoi?
Non ce n'est pas un Singleton mais un Builder.
Il n'est pas logique que 2 instances utilisent le même Builder, alors qu'il peut en utiliser un autre.
7- Comment prévenir l’utilisateur que la tâche est terminée ? Proposez au moins un patron qui s’applique parfaitement à ce cas très précis 
On peut prévenir l'utilisateur que la tâche est terminée, soit avec un observeur, qui s'adapte dans ce cas très précis.
Nous avons choisi de prévenir que la tâche est fini avec une lambda.
