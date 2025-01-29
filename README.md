# GD-Our-World


*GD Our World Jump mechanic en hoe het werkt.*

In de movement script heb ik een Input.GetKey die checked of de space knop wordt geklikt, als dat gebeurt dan checked hij daarna of de bool "onGround" true is.
Ik heb een private OnCollisionEnter, die checked of er een collision is met een gameobject die de tag "ground" heeft, als dat zo is dan zet het de onGround boolean naa true.

Als de input space is en de Onground true is dan geeft het de player's rigidbody een zet omhoog door de AddForce function, daarna valt hij naar beneden door gravity (idk unity heeft dat al).
De snelheid op hoe dat gebeurt is aan te passen door de ForceMode in de AddForce aan te passe. Ik heb het op .Impulse staan omdat dat goed voelt.
Er staat ook een trigger voor een jump animatie.
