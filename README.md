# SVG Icons and flags for Blazor
This component helps you to display a SVG image in your application. All the icon are embedded in the component. Also, you have the complete SVG images for flags.

The class `SVGIcons` has already 1298 SVG images ready to use. `SVGFlags` contains all the flags in SVG in 2 formats: square and wide.

### OnClick
This is an `EventCallback<MouseEventArgs>` if you want to receive a callback when you user clicks on the image.

### Color
The color of the SVG image.

### Size 
The size of the image in pixel (default 24 pixels). This value is applied to `Height` and `Width`. So, the image is a square.

### StrokeWidth
The size of the pen to draw the image (default 2 pixels)

### Elements
SVG image to display. If you have an SVG image pass only the content of SVG tag. For example if you want to display `_2fa`:

```
<path stroke='none' d='M0 0h24v24H0z' fill='none' />
<path d='M7 16h-4l3.47 -4.66a2 2 0 1 0 -3.47 -1.54' />
<path d='M10 16v-8h4' />
<line x1='10' y1='12' x2='13' y2='12' />
<path d='M17 16v-6a2 2 0 0 1 4 0v6' />
<line x1='17' y1='13' x2='21' y2='13' />
```

### Filled
Define is you want to fill the image.

### Rotate
The rotation to apply to your image

### Examples

#### Basic use

```
<SVGIcon Elements="@SVGIcons.Code" />
```

#### Size and color

```
<SVGIcon Elements="@SVGIcon.Credit_card" Size="16" Color="blue" />
```

#### CSS class

```
<SVGIcon class="icon" Elements="@SVGIcons.Alarm" />
<SVGIcon class="icon" Elements="@SVGIcons.Code" />
<SVGIcon class="icon" Elements="@SVGIcons.Copy" Color="blue" />
```

# Flags

### OnClick
This is an `EventCallback<MouseEventArgs>` if you want to receive a callback when you user clicks on the image.

### FlagType
The image could be:
- Square 
- Wide

### Width
It is the width of the image. The default value is `120`.

### Height
It is the height of the image. The default value is `100`.

### CountryCode
This is the code of the country with 2 letters.

| Country code | Country name |
|--------------|--------------|
| ac | Ascension Island |
| ad | Andorra |
| ae | United Arab Emirates |
| af | Afghanistan |
| ag | Antigua and Barbuda |
| ai | Anguilla |
| al | Albania |
| am | Armenia |
| ao | Angola |
| aq | Antarctica |
| ar | Argentina |
| as | American Samoa |
| at | Austria |
| au | Australia |
| aw | Aruba |
| ax | Aland Islands |
| az | Azerbaijan |
| ba | Bosnia and Herzegovina |
| bb | Barbados |
| bd | Bangladesh |
| be | Belgium |
| bf | Burkina Faso |
| bg | Bulgaria |
| bh | Bahrain |
| bi | Burundi |
| bj | Benin |
| bl | Saint Barthélemy |
| bm | Bermuda |
| bn | Brunei Darussalam |
| bo | Bolivia (Plurinational State of) |
| bq | Bonaire, Sint Eustatius and Saba |
| br | Brazil |
| bs | Bahamas |
| bt | Bhutan |
| bv | Bouvet Island |
| bw | Botswana |
| by | Belarus |
| bz | Belize |
| ca | Canada |
| cc | Cocos (Keeling) Islands |
| cd | Democratic Republic of the Congo |
| cf | Central African Republic |
| cg | Republic of the Congo |
| ch | Switzerland |
| ci | Côte d'Ivoire |
| ck | Cook Islands |
| cl | Chile |
| cm | Cameroon |
| cn | China |
| co | Colombia |
| cp | Clipperton Island |
| cr | Costa Rica |
| cu | Cuba |
| cv | Cabo Verde |
| cw | Curaçao |
| cx | Christmas Island |
| cy | Cyprus |
| cz | Czech Republic |
| de | Germany |
| dg | Diego Garcia |
| dj | Djibouti |
| dk | Denmark |
| dm | Dominica |
| do | Dominican Republic |
| dz | Algeria |
| ea | Ceuta & Melilla |
| ec | Ecuador |
| ee | Estonia |
| eg | Egypt |
| eh | Western Sahara |
| er | Eritrea |
| es | Spain |
| es-ct | Catalonia |
| es-ga | Galicia |
| et | Ethiopia |
| eu | Europe |
| fi | Finland |
| fj | Fiji |
| fk | Falkland Islands |
| fm | Federated States of Micronesia |
| fo | Faroe Islands |
| fr | France |
| ga | Gabon |
| gb | United Kingdom |
| gb-eng | England |
| gb-nir | Northern Ireland |
| gb-sct | Scotland |
| gb-wls | Wales |
| gd | Grenada |
| ge | Georgia |
| gf | French Guiana |
| gg | Guernsey |
| gh | Ghana |
| gi | Gibraltar |
| gl | Greenland |
| gm | Gambia |
| gn | Guinea |
| gp | Guadeloupe |
| gq | Equatorial Guinea |
| gr | Greece |
| gs | South Georgia and the South Sandwich Islands |
| gt | Guatemala |
| gu | Guam |
| gw | Guinea-Bissau |
| gy | Guyana |
| hk | Hong Kong |
| hm | Heard Island and McDonald Islands |
| hn | Honduras |
| hr | Croatia |
| ht | Haiti |
| hu | Hungary |
| ic | Canary Islands |
| id | Indonesia |
| ie | Ireland |
| il | Israel |
| im | Isle of Man |
| in | India |
| io | British Indian Ocean Territory |
| iq | Iraq |
| ir | Iran (Islamic Republic of) |
| is | Iceland |
| it | Italy |
| lg | LGBT |
| je | Jersey |
| jm | Jamaica |
| jo | Jordan |
| jp | Japan |
| ke | Kenya |
| kg | Kyrgyzstan |
| kh | Cambodia |
| ki | Kiribati |
| km | Comoros |
| kn | Saint Kitts and Nevis |
| kp | North Korea |
| kr | South Korea |
| kw | Kuwait |
| ky | Cayman Islands |
| kz | Kazakhstan |
| la | Laos |
| lb | Lebanon |
| lc | Saint Lucia |
| li | Liechtenstein |
| lk | Sri Lanka |
| lr | Liberia |
| ls | Lesotho |
| lt | Lithuania |
| lu | Luxembourg |
| lv | Latvia |
| ly | Libya |
| ma | Morocco |
| mc | Monaco |
| md | Moldova |
| me | Montenegro |
| mf | Saint Martin |
| mg | Madagascar |
| mh | Marshall Islands |
| mk | North Macedonia |
| ml | Mali |
| mm | Myanmar |
| mn | Mongolia |
| mo | Macau |
| mp | Northern Mariana Islands |
| mq | Martinique |
| mr | Mauritania |
| ms | Montserrat |
| mt | Malta |
| mu | Mauritius |
| mv | Maldives |
| mw | Malawi |
| mx | Mexico |
| my | Malaysia |
| mz | Mozambique |
| na | Namibia |
| nc | New Caledonia |
| ne | Niger |
| nf | Norfolk Island |
| ng | Nigeria |
| ni | Nicaragua |
| nl | Netherlands |
| no | Norway |
| np | Nepal |
| nr | Nauru |
| nu | Niue |
| nz | New Zealand |
| om | Oman |
| pa | Panama |
| pe | Peru |
| pf | French Polynesia |
| pg | Papua New Guinea |
| ph | Philippines |
| pk | Pakistan |
| pl | Poland |
| pm | Saint Pierre and Miquelon |
| pn | Pitcairn |
| pr | Puerto Rico |
| ps | State of Palestine |
| pt | Portugal |
| pw | Palau |
| py | Paraguay |
| qa | Qatar |
| re | Réunion |
| ro | Romania |
| rs | Serbia |
| ru | Russia |
| rw | Rwanda |
| sa | Saudi Arabia |
| sb | Solomon Islands |
| sc | Seychelles |
| sd | Sudan |
| se | Sweden |
| sg | Singapore |
| sh | Saint Helena, Ascension and Tristan da Cunha |
| si | Slovenia |
| sj | Svalbard and Jan Mayen |
| sk | Slovakia |
| sl | Sierra Leone |
| sm | San Marino |
| sn | Senegal |
| so | Somalia |
| sr | Suriname |
| ss | South Sudan |
| st | Sao Tome and Principe |
| sv | El Salvador |
| sx | Sint Maarten |
| sy | Syrian Arab Republic |
| sz | Swaziland |
| ta | Tristan da Cunha |
| tc | Turks and Caicos Islands |
| td | Chad |
| tf | French Southern Territories |
| tg | Togo |
| th | Thailand |
| tj | Tajikistan |
| tk | Tokelau |
| tl | Timor-Leste |
| tm | Turkmenistan |
| tn | Tunisia |
| to | Tonga |
| tr | Turkey |
| tt | Trinidad and Tobago |
| tv | Tuvalu |
| tw | Taiwan |
| tz | Tanzania |
| ua | Ukraine |
| ug | Uganda |
| um | United States Minor Outlying Islands |
| un | United Nations |
| us | United States of America |
| uy | Uruguay |
| uz | Uzbekistan |
| va | Holy See |
| vc | Saint Vincent and the Grenadines |
| ve | Venezuela (Bolivarian Republic of) |
| vg | Virgin Islands (British) |
| vi | Virgin Islands (U.S.) |
| vn | Vietnam |
| vu | Vanuatu |
| wf | Wallis and Futuna |
| ws | Samoa |
| xk | Kosovo |
| xx | Unknown |
| ye | Yemen |
| yt | Mayotte |
| za | South Africa |
| zm | Zambia |
| zw | Zimbabwe |

### Examples

```
<SVGFlag CountryCode="GB" FlagType="FlagType.Wide" Width="75" Height="50" />
<SVGFlag CountryCode="US" FlagType="FlagType.Square" Width="50" Height="50" />
```

### Screenshot

![Example of Wide flags](https://user-images.githubusercontent.com/9497415/151448394-b32521b7-e06b-49ce-826e-d413cbdddb8e.png)

![Example of square flags](https://user-images.githubusercontent.com/9497415/151448495-f783f48e-9a36-4570-ae12-bd126c685e16.png)