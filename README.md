# GD-Our-World


*GD Our World Jump mechanic en hoe het werkt.*


In de movement script heb ik een Input.GetKey die checked of de space knop wordt geklikt, als dat gebeurt dan checked hij daarna of de bool "onGround" true is.
Ik heb een private OnCollisionEnter, die checked of er een collision is met een gameobject die de tag "ground" heeft, als dat zo is dan zet het de onGround boolean naa true.

Als de input space is en de Onground true is dan geeft het de player's rigidbody een zet omhoog door de AddForce function, daarna valt hij naar beneden door gravity (idk unity heeft dat al).
De snelheid op hoe dat gebeurt is aan te passen door de ForceMode in de AddForce aan te passe. Ik heb het op .Impulse staan omdat dat goed voelt.
Er staat ook een trigger voor een jump animatie.



*GD Our World Collect mechanic en hoe het werkt.*


Er zijn katten in de map (ze hetten coin volgens mijn preference) met een collider box en een rigidbody. Ze hebben een tag genaamd Coin.
Dan heb ik een script in de player character gezet waar de movement script ook is.
Eerst heb ik een int voo de hoeveelheid coins (int omdat het hele getallen zijn), daarna een public text voor de ui, zodat het kan displayen hoeveel coins/katten je hebt, en als laatste AudioSource en Audio clip voor de sfx.

In een private OnTriggerEnter ion de heb ik een if statement die kijkt naar de tag van elke collisioned object, als de tag Coin is dan doet het de volgende; Coin int add 1, text ui change, destroy gameobject, en dan als laatste speelt ie een mp3 file af.
