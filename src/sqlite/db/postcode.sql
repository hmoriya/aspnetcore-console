CREATE TABLE japan (
  postcode	INTEGER,
  prefecture	TEXT,
  city		TEXT,
  address	TEXT,
  rubi_pref	TEXT,
  rubi_city	TEXT,
  rubi_addr	TEXT,
  PRIMARY KEY (postcode, prefecture, city, address, rubi_addr)
);
CREATE INDEX japan_idx ON japan(postcode);

CREATE TABLE office (
  postcode	INTEGER,
  name		TEXT,
  rubi		TEXT,
  prefecture	TEXT,
  city		TEXT,
  address	TEXT,
  PRIMARY KEY (postcode, name)
);
CREATE INDEX office_idx ON office(postcode);