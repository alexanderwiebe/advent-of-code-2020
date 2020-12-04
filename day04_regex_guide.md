# regex

didn't want to have to deal with formatting as part of the solution
used vs code find replace with this pattern

```
\n(?!\W)
```

and replace with a space

to remove empty lines and make passports be one per line

dunno impact to part 2 of the questions so keeping original

then i just used the following regex to match and count the matches

```
(?=.*byr)(?=.*iyr)(?=.*eyr)(?=.*hgt)(?=.*hcl)(?=.*ecl)(?=.*pid).*$
```
