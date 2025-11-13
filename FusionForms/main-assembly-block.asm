0:  33 c0                   xor    eax,eax
2:  83 7c 0a 54 00          cmp    DWORD PTR [edx+ecx*1+0x54],0x0
7:  0f 84 02 01 00 00       je     0x10f
d:  83 7c 0a 54 01          cmp    DWORD PTR [edx+ecx*1+0x54],0x1
12: 0f 84 17 01 00 00       je     0x12f
18: 83 7c 0a 54 02          cmp    DWORD PTR [edx+ecx*1+0x54],0x2
1d: 0f 84 2c 01 00 00       je     0x14f
23: 83 7c 0a 54 03          cmp    DWORD PTR [edx+ecx*1+0x54],0x3
28: 0f 84 41 01 00 00       je     0x16f
2e: 83 7c 0a 54 04          cmp    DWORD PTR [edx+ecx*1+0x54],0x4
33: 0f 84 56 01 00 00       je     0x18f
39: 83 7c 0a 54 05          cmp    DWORD PTR [edx+ecx*1+0x54],0x5
3e: 0f 84 6b 01 00 00       je     0x1af
44: 83 7c 0a 54 06          cmp    DWORD PTR [edx+ecx*1+0x54],0x6
49: 0f 84 83 01 00 00       je     0x1d2
4f: 83 7c 0a 54 07          cmp    DWORD PTR [edx+ecx*1+0x54],0x7
54: 0f 84 98 01 00 00       je     0x1f2
5a: 83 7c 0a 54 08          cmp    DWORD PTR [edx+ecx*1+0x54],0x8
5f: 0f 84 ad 01 00 00       je     0x212
65: 83 7c 0a 54 09          cmp    DWORD PTR [edx+ecx*1+0x54],0x9
6a: 0f 84 c2 01 00 00       je     0x232
70: 83 7c 0a 54 0a          cmp    DWORD PTR [edx+ecx*1+0x54],0xa
75: 0f 84 d7 01 00 00       je     0x252
7b: 83 7c 0a 54 0b          cmp    DWORD PTR [edx+ecx*1+0x54],0xb
80: 0f 84 ec 01 00 00       je     0x272
86: 83 7c 0a 54 0c          cmp    DWORD PTR [edx+ecx*1+0x54],0xc
8b: 0f 84 01 02 00 00       je     0x292
91: 83 7c 0a 54 0d          cmp    DWORD PTR [edx+ecx*1+0x54],0xd
96: 0f 84 16 02 00 00       je     0x2b2
9c: 83 7c 0a 54 0e          cmp    DWORD PTR [edx+ecx*1+0x54],0xe
a1: 0f 84 2b 02 00 00       je     0x2d2
a7: 83 7c 0a 54 0f          cmp    DWORD PTR [edx+ecx*1+0x54],0xf
ac: 0f 84 40 02 00 00       je     0x2f2
b2: 83 7c 0a 54 10          cmp    DWORD PTR [edx+ecx*1+0x54],0x10
b7: 0f 84 55 02 00 00       je     0x312
bd: 83 7c 0a 54 11          cmp    DWORD PTR [edx+ecx*1+0x54],0x11
c2: 0f 84 6a 02 00 00       je     0x332
c8: 83 7c 0a 54 12          cmp    DWORD PTR [edx+ecx*1+0x54],0x12
cd: 0f 84 7f 02 00 00       je     0x352
d3: 83 7c 0a 54 13          cmp    DWORD PTR [edx+ecx*1+0x54],0x13
d8: 0f 84 94 02 00 00       je     0x372
de: 83 7c 0a 54 14          cmp    DWORD PTR [edx+ecx*1+0x54],0x14
e3: 0f 84 a9 02 00 00       je     0x392
e9: 83 7c 0a 54 15          cmp    DWORD PTR [edx+ecx*1+0x54],0x15
ee: 0f 84 be 02 00 00       je     0x3b2
f4: 83 7c 0a 54 16          cmp    DWORD PTR [edx+ecx*1+0x54],0x16
f9: 0f 84 d3 02 00 00       je     0x3d2
ff: 83 7c 0a 54 17          cmp    DWORD PTR [edx+ecx*1+0x54],0x17
104:    0f 84 e8 02 00 00       je     0x3f2
10a:    e9 03 03 00 00          jmp    0x412
10f:    83 ff 00                cmp    edi,0x0
112:    0f 84 01 03 00 00       je     0x419
118:    83 ff 79                cmp    edi,0x79
11b:    0f 84 f8 02 00 00       je     0x419
121:    83 ff 79                cmp    edi,0x79
124:    0f 84 ef 02 00 00       je     0x419
12a:    e9 e3 02 00 00          jmp    0x412
12f:    83 ff 01                cmp    edi,0x1
132:    0f 84 e1 02 00 00       je     0x419
138:    83 ff 79                cmp    edi,0x79
13b:    0f 84 d8 02 00 00       je     0x419
141:    83 ff 79                cmp    edi,0x79
144:    0f 84 cf 02 00 00       je     0x419
14a:    e9 c3 02 00 00          jmp    0x412
14f:    83 ff 02                cmp    edi,0x2
152:    0f 84 c1 02 00 00       je     0x419
158:    83 ff 79                cmp    edi,0x79
15b:    0f 84 b8 02 00 00       je     0x419
161:    83 ff 79                cmp    edi,0x79
164:    0f 84 af 02 00 00       je     0x419
16a:    e9 a3 02 00 00          jmp    0x412
16f:    83 ff 03                cmp    edi,0x3
172:    0f 84 a1 02 00 00       je     0x419
178:    83 ff 79                cmp    edi,0x79
17b:    0f 84 98 02 00 00       je     0x419
181:    83 ff 79                cmp    edi,0x79
184:    0f 84 8f 02 00 00       je     0x419
18a:    e9 83 02 00 00          jmp    0x412
18f:    83 ff 04                cmp    edi,0x4
192:    0f 84 81 02 00 00       je     0x419
198:    83 ff 79                cmp    edi,0x79
19b:    0f 84 78 02 00 00       je     0x419
1a1:    83 ff 79                cmp    edi,0x79
1a4:    0f 84 6f 02 00 00       je     0x419
1aa:    e9 63 02 00 00          jmp    0x412
1af:    83 ff 05                cmp    edi,0x5
1b2:    0f 84 61 02 00 00       je     0x419
1b8:    83 ff 79                cmp    edi,0x79
1bb:    0f 84 58 02 00 00       je     0x419
1c1:    81 ff 79 00 00 00       cmp    edi,0x79
1c7:    0f 84 4c 02 00 00       je     0x419
1cd:    e9 40 02 00 00          jmp    0x412
1d2:    83 ff 06                cmp    edi,0x6
1d5:    0f 84 3e 02 00 00       je     0x419
1db:    83 ff 79                cmp    edi,0x79
1de:    0f 84 35 02 00 00       je     0x419
1e4:    83 ff 79                cmp    edi,0x79
1e7:    0f 84 2c 02 00 00       je     0x419
1ed:    e9 20 02 00 00          jmp    0x412
1f2:    83 ff 07                cmp    edi,0x7
1f5:    0f 84 1e 02 00 00       je     0x419
1fb:    83 ff 79                cmp    edi,0x79
1fe:    0f 84 15 02 00 00       je     0x419
204:    83 ff 79                cmp    edi,0x79
207:    0f 84 0c 02 00 00       je     0x419
20d:    e9 00 02 00 00          jmp    0x412
212:    83 ff 08                cmp    edi,0x8
215:    0f 84 fe 01 00 00       je     0x419
21b:    83 ff 79                cmp    edi,0x79
21e:    0f 84 f5 01 00 00       je     0x419
224:    83 ff 79                cmp    edi,0x79
227:    0f 84 ec 01 00 00       je     0x419
22d:    e9 e0 01 00 00          jmp    0x412
232:    83 ff 09                cmp    edi,0x9
235:    0f 84 de 01 00 00       je     0x419
23b:    83 ff 79                cmp    edi,0x79
23e:    0f 84 d5 01 00 00       je     0x419
244:    83 ff 79                cmp    edi,0x79
247:    0f 84 cc 01 00 00       je     0x419
24d:    e9 c0 01 00 00          jmp    0x412
252:    83 ff 0a                cmp    edi,0xa
255:    0f 84 be 01 00 00       je     0x419
25b:    83 ff 79                cmp    edi,0x79
25e:    0f 84 b5 01 00 00       je     0x419
264:    83 ff 79                cmp    edi,0x79
267:    0f 84 ac 01 00 00       je     0x419
26d:    e9 a0 01 00 00          jmp    0x412
272:    83 ff 0b                cmp    edi,0xb
275:    0f 84 9e 01 00 00       je     0x419
27b:    83 ff 79                cmp    edi,0x79
27e:    0f 84 95 01 00 00       je     0x419
284:    83 ff 79                cmp    edi,0x79
287:    0f 84 8c 01 00 00       je     0x419
28d:    e9 80 01 00 00          jmp    0x412
292:    83 ff 0c                cmp    edi,0xc
295:    0f 84 7e 01 00 00       je     0x419
29b:    83 ff 79                cmp    edi,0x79
29e:    0f 84 75 01 00 00       je     0x419
2a4:    83 ff 79                cmp    edi,0x79
2a7:    0f 84 6c 01 00 00       je     0x419
2ad:    e9 60 01 00 00          jmp    0x412
2b2:    83 ff 0d                cmp    edi,0xd
2b5:    0f 84 5e 01 00 00       je     0x419
2bb:    83 ff 79                cmp    edi,0x79
2be:    0f 84 55 01 00 00       je     0x419
2c4:    83 ff 79                cmp    edi,0x79
2c7:    0f 84 4c 01 00 00       je     0x419
2cd:    e9 40 01 00 00          jmp    0x412
2d2:    83 ff 0e                cmp    edi,0xe
2d5:    0f 84 3e 01 00 00       je     0x419
2db:    83 ff 79                cmp    edi,0x79
2de:    0f 84 35 01 00 00       je     0x419
2e4:    83 ff 79                cmp    edi,0x79
2e7:    0f 84 2c 01 00 00       je     0x419
2ed:    e9 20 01 00 00          jmp    0x412
2f2:    83 ff 0f                cmp    edi,0xf
2f5:    0f 84 1e 01 00 00       je     0x419
2fb:    83 ff 79                cmp    edi,0x79
2fe:    0f 84 15 01 00 00       je     0x419
304:    83 ff 79                cmp    edi,0x79
307:    0f 84 0c 01 00 00       je     0x419
30d:    e9 00 01 00 00          jmp    0x412
312:    83 ff 10                cmp    edi,0x10
315:    0f 84 fe 00 00 00       je     0x419
31b:    83 ff 79                cmp    edi,0x79
31e:    0f 84 f5 00 00 00       je     0x419
324:    83 ff 79                cmp    edi,0x79
327:    0f 84 ec 00 00 00       je     0x419
32d:    e9 e0 00 00 00          jmp    0x412
332:    83 ff 11                cmp    edi,0x11
335:    0f 84 de 00 00 00       je     0x419
33b:    83 ff 79                cmp    edi,0x79
33e:    0f 84 d5 00 00 00       je     0x419
344:    83 ff 79                cmp    edi,0x79
347:    0f 84 cc 00 00 00       je     0x419
34d:    e9 c0 00 00 00          jmp    0x412
352:    83 ff 12                cmp    edi,0x12
355:    0f 84 be 00 00 00       je     0x419
35b:    83 ff 79                cmp    edi,0x79
35e:    0f 84 b5 00 00 00       je     0x419
364:    83 ff 79                cmp    edi,0x79
367:    0f 84 ac 00 00 00       je     0x419
36d:    e9 a0 00 00 00          jmp    0x412
372:    83 ff 13                cmp    edi,0x13
375:    0f 84 9e 00 00 00       je     0x419
37b:    83 ff 79                cmp    edi,0x79
37e:    0f 84 95 00 00 00       je     0x419
384:    83 ff 79                cmp    edi,0x79
387:    0f 84 8c 00 00 00       je     0x419
38d:    e9 80 00 00 00          jmp    0x412
392:    83 ff 14                cmp    edi,0x14
395:    0f 84 7e 00 00 00       je     0x419
39b:    83 ff 79                cmp    edi,0x79
39e:    0f 84 75 00 00 00       je     0x419
3a4:    83 ff 79                cmp    edi,0x79
3a7:    0f 84 6c 00 00 00       je     0x419
3ad:    e9 60 00 00 00          jmp    0x412
3b2:    83 ff 15                cmp    edi,0x15
3b5:    0f 84 5e 00 00 00       je     0x419
3bb:    83 ff 79                cmp    edi,0x79
3be:    0f 84 55 00 00 00       je     0x419
3c4:    83 ff 79                cmp    edi,0x79
3c7:    0f 84 4c 00 00 00       je     0x419
3cd:    e9 40 00 00 00          jmp    0x412
3d2:    83 ff 16                cmp    edi,0x16
3d5:    0f 84 3e 00 00 00       je     0x419
3db:    83 ff 79                cmp    edi,0x79
3de:    0f 84 35 00 00 00       je     0x419
3e4:    83 ff 79                cmp    edi,0x79
3e7:    0f 84 2c 00 00 00       je     0x419
3ed:    e9 20 00 00 00          jmp    0x412
3f2:    83 ff 17                cmp    edi,0x17
3f5:    0f 84 1e 00 00 00       je     0x419
3fb:    83 ff 79                cmp    edi,0x79
3fe:    0f 84 15 00 00 00       je     0x419
404:    83 ff 79                cmp    edi,0x79
407:    0f 84 0c 00 00 00       je     0x419
40d:    e9 00 00 00 00          jmp    0x412
412:    33 c0                   xor    eax,eax
414:    e9 d2 cf 60 ff          jmp    0xff60d3eb
419:    b8 01 00 00 00          mov    eax,0x1
41e:    e9 c8 cf 60 ff          jmp    0xff60d3eb 