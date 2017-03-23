#!/usr/bin/awk -f

  BEGIN {
    FS = ","
    print "BEGIN;";
  }
  {
    printf("INSERT INTO japan VALUES(%s,%s,%s,%s,%s,%s,%s);\n",
           $3, $7, $8, $9, $4, $5, $6);
  }
  END {
    print "COMMIT;";
  }