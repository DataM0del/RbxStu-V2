# CS_ARCH_ARM, CS_MODE_ARM, None
0x06,0x20,0x42,0xe2 = sub r2, r2, #6
0x06,0x20,0x42,0xe2 = sub r2, r2, #6
0x03,0x20,0x42,0xe0 = sub r2, r2, r3
0x03,0x20,0x42,0xe0 = sub r2, r2, r3
0x06,0x20,0x82,0xe2 = add r2, r2, #6
0x06,0x20,0x82,0xe2 = add r2, r2, #6
0x03,0x20,0x82,0xe0 = add r2, r2, r3
0x03,0x20,0x82,0xe0 = add r2, r2, r3
0x06,0x20,0x02,0xe2 = and r2, r2, #6
0x06,0x20,0x02,0xe2 = and r2, r2, #6
0x03,0x20,0x02,0xe0 = and r2, r2, r3
0x03,0x20,0x02,0xe0 = and r2, r2, r3
0x06,0x20,0x82,0xe3 = orr r2, r2, #6
0x06,0x20,0x82,0xe3 = orr r2, r2, #6
0x03,0x20,0x82,0xe1 = orr r2, r2, r3
0x03,0x20,0x82,0xe1 = orr r2, r2, r3
0x06,0x20,0x22,0xe2 = eor r2, r2, #6
0x06,0x20,0x22,0xe2 = eor r2, r2, #6
0x03,0x20,0x22,0xe0 = eor r2, r2, r3
0x03,0x20,0x22,0xe0 = eor r2, r2, r3
0x06,0x20,0xc2,0xe3 = bic r2, r2, #6
0x06,0x20,0xc2,0xe3 = bic r2, r2, #6
0x03,0x20,0xc2,0xe1 = bic r2, r2, r3
0x03,0x20,0xc2,0xe1 = bic r2, r2, r3
0x06,0x20,0x52,0x02 = subseq r2, r2, #6
0x06,0x20,0x52,0x02 = subseq r2, r2, #6
0x03,0x20,0x52,0x00 = subseq r2, r2, r3
0x03,0x20,0x52,0x00 = subseq r2, r2, r3
0x06,0x20,0x92,0x02 = addseq r2, r2, #6
0x06,0x20,0x92,0x02 = addseq r2, r2, #6
0x03,0x20,0x92,0x00 = addseq r2, r2, r3
0x03,0x20,0x92,0x00 = addseq r2, r2, r3
0x06,0x20,0x12,0x02 = andseq r2, r2, #6
0x06,0x20,0x12,0x02 = andseq r2, r2, #6
0x03,0x20,0x12,0x00 = andseq r2, r2, r3
0x03,0x20,0x12,0x00 = andseq r2, r2, r3
0x06,0x20,0x92,0x03 = orrseq r2, r2, #6
0x06,0x20,0x92,0x03 = orrseq r2, r2, #6
0x03,0x20,0x92,0x01 = orrseq r2, r2, r3
0x03,0x20,0x92,0x01 = orrseq r2, r2, r3
0x06,0x20,0x32,0x02 = eorseq r2, r2, #6
0x06,0x20,0x32,0x02 = eorseq r2, r2, #6
0x03,0x20,0x32,0x00 = eorseq r2, r2, r3
0x03,0x20,0x32,0x00 = eorseq r2, r2, r3
0x06,0x20,0xd2,0x03 = bicseq r2, r2, #6
0x06,0x20,0xd2,0x03 = bicseq r2, r2, #6
0x03,0x20,0xd2,0x01 = bicseq r2, r2, r3
0x03,0x20,0xd2,0x01 = bicseq r2, r2, r3
0x7b,0x00,0x8f,0xe2 = add r0, pc, #0x7b
