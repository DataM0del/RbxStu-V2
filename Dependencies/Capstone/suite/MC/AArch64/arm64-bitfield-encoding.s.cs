# CS_ARCH_AARCH64, 0, None
0x41,0x3c,0x01,0x33 = bfxil	w1, w2, #1, #15
0x41,0x3c,0x41,0xb3 = bfxil	x1, x2, #1, #15
0x41,0x3c,0x01,0x13 = sbfx	w1, w2, #1, #15
0x41,0x3c,0x41,0x93 = sbfx	x1, x2, #1, #15
0x41,0x3c,0x01,0x53 = ubfx	w1, w2, #1, #15
0x41,0x3c,0x41,0xd3 = ubfx	x1, x2, #1, #15
0x1f,0x00,0x01,0x13 = sbfiz	wzr, w0, #31, #1
0x1f,0x00,0x61,0x93 = sbfiz	xzr, x0, #31, #1
0x1f,0x00,0x01,0x53 = lsl	wzr, w0, #31
0x1f,0x00,0x61,0xd3 = ubfiz	xzr, x0, #31, #1
0x41,0x3c,0x83,0x13 = extr	w1, w2, w3, #15
0x62,0x04,0xc4,0x93 = extr	x2, x3, x4, #1