1.
  SELECT lista.ev, dalok.cim, eloadok.nev
  FROM lista, dalok, eloadok
  WHERE lista.ev = '2001' AND lista.helyezes = 1
      AND lista.dalid = dalok.dalid AND dalok.eloadoid = eloadok.eloadoid;  
  
2.
  SELECT lista.ev, dalok.cim, eloadok.nev
  FROM lista, dalok, eloadok
  WHERE lista.ev = '2019' AND lista.helyezes = 1,2,3
      AND lista.dalid = dalok.dalid AND dalok.eloadoid = eloadok.eloadoid; 
3.
SELECT * FROM eloadok WHERE Nev LIKE 'b%'; 