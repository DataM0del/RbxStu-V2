# CS_ARCH_HPPA, CS_MODE_HPPA_20+CS_MODE_BIG_ENDIAN, None
0x08,0x41,0x66,0x03 = add,<=	r1,rp,r3
0x08,0x41,0x07,0x03 = add,c	r1,rp,r3
0x08,0x41,0x57,0x03 = add,c,>=	r1,rp,r3
0x08,0x41,0x07,0x23 = add,dc,*	r1,rp,r3
0x08,0x41,0x27,0x23 = add,dc,*=	r1,rp,r3
0x08,0x41,0x0a,0x03 = add,l	r1,rp,r3
0x08,0x41,0x4a,0x03 = add,l,<	r1,rp,r3
0x08,0x41,0x0e,0x03 = add,tsv	r1,rp,r3
0x08,0x41,0x7e,0x03 = add,tsv,>	r1,rp,r3
0x08,0x41,0x0f,0x03 = add,c,tsv	r1,rp,r3
0x08,0x41,0x3f,0x03 = add,c,tsv,<>	r1,rp,r3
0x08,0x41,0x0f,0x23 = add,dc,tsv,*	r1,rp,r3
0x08,0x41,0x5f,0x23 = add,dc,tsv,*>=	r1,rp,r3
0x08,0x41,0x06,0xc3 = shladd	r1,3,rp,r3
0x08,0x41,0x0a,0xc3 = shladd,l	r1,3,rp,r3
0x08,0x41,0x0e,0xc3 = shladd,tsv	r1,3,rp,r3
0x08,0x41,0xce,0xc3 = shladd,tsv,sv	r1,3,rp,r3
0x08,0x41,0x04,0x03 = sub	r1,rp,r3
0x08,0x41,0x04,0xc3 = sub,tc	r1,rp,r3
0x08,0x41,0x05,0x03 = sub,b	r1,rp,r3
0x08,0x41,0x0c,0x03 = sub,tsv	r1,rp,r3
0x08,0x41,0x0c,0xc3 = sub,tsv,tc	r1,rp,r3
0x08,0x41,0x0d,0x03 = sub,b,tsv	r1,rp,r3
0x08,0x41,0x6d,0x23 = sub,db,tsv,*<=	r1,rp,r3
0x08,0x41,0x02,0x43 = or	r1,rp,r3
0x08,0x41,0x22,0x43 = or,=	r1,rp,r3
0x08,0x41,0x02,0x83 = xor	r1,rp,r3
0x08,0x41,0x62,0x83 = xor,<=	r1,rp,r3
0x08,0x41,0x02,0x03 = and	r1,rp,r3
0x08,0x41,0x62,0x03 = and,<=	r1,rp,r3
0x08,0x41,0x00,0x03 = andcm	r1,rp,r3
0x08,0x41,0x60,0x03 = andcm,<=	r1,rp,r3
0x08,0x41,0x09,0x83 = uaddcm	r1,rp,r3
0x08,0x41,0x49,0x83 = uaddcm,sbz	r1,rp,r3
0x08,0x41,0x09,0xc3 = uaddcm,tc	r1,rp,r3
0x08,0x41,0x03,0x83 = uxor	r1,rp,r3
0x08,0x41,0x43,0x83 = uxor,sbz	r1,rp,r3
0x08,0x41,0x04,0x43 = ds	r1,rp,r3
0x08,0x41,0xa4,0x43 = ds,<<=	r1,rp,r3
0x08,0x41,0x08,0x83 = cmpclr	r1,rp,r3
0x08,0x41,0x98,0x83 = cmpclr,>>=	r1,rp,r3
0x08,0x20,0x0b,0x82 = dcor	r1,rp
0x08,0x20,0x0b,0xc2 = dcor,i	r1,rp
0x08,0x20,0x4b,0xc2 = dcor,i,sbz	r1,rp
0xb4,0x22,0x01,0xbc = addi	0xde,r1,rp
0xb4,0x22,0x09,0xbc = addi,tsv	0xde,r1,rp
0xb0,0x22,0x01,0xbc = addi,tc	0xde,r1,rp
0xb0,0x22,0x09,0xbc = addi,tsv,tc	0xde,r1,rp
0xb0,0x22,0x69,0xbc = addi,tsv,tc,<=	0xde,r1,rp
0x94,0x22,0x01,0xbc = subi	0xde,r1,rp
0x94,0x22,0x09,0xbc = subi,tsv	0xde,r1,rp
0x94,0x22,0x29,0xbc = subi,tsv,=	0xde,r1,rp
0x90,0x43,0x01,0xbc = cmpiclr	0xde,rp,r3
0x90,0x43,0x91,0xbc = cmpiclr,>>=	0xde,rp,r3
0xd0,0x41,0x0f,0x83 = shrpd,*	r1,rp,3,r3
0xd0,0x41,0x4f,0x83 = shrpd,*<	r1,rp,3,r3
0xd0,0x41,0x0b,0x83 = shrpw	r1,rp,3,r3
0xd0,0x41,0x4b,0x83 = shrpw,<	r1,rp,3,r3
0xd0,0x22,0x16,0x1c = extrd,s,*	r1,sar,4,rp
0xd8,0x22,0x07,0xdc = extrd,s,*	r1,0x1e,4,rp
0xd8,0x22,0x03,0xdc = extrd,u,*	r1,0x1e,4,rp
0xd8,0x22,0xc3,0xdc = extrd,u,*>=	r1,0x1e,4,rp