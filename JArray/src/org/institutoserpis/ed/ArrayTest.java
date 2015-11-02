package org.institutoserpis.ed;

import static org.junit.Assert.*;

import org.junit.Test;

public class ArrayTest {

	@Test
	public void menor() {
		assertEquals(5, Array.menor(new int[]{5,9,6,14}));
		assertEquals(3, Array.menor(new int[]{5,9,3,14}));
		assertEquals(7, Array.menor(new int[]{9,8,12,7}));
	}

	@Test
	public void indexOf() {
		assertEquals(0, Array.indexOf(new int[]{7,21,9,13}, 7));
		assertEquals(1, Array.indexOf(new int[]{7,21,9,13}, 21));
		assertEquals(3, Array.indexOf(new int[]{7,21,9,13}, 13));
	}
	@Test
	public void indexOf_empty () {
		assertEquals (-1, Array.indexOf(new int[]{}, 33));
	}
	@Test
	public void sort (){
		int[] v = {9,8,12,7};
		Array.sort(v);
		assertArrayEquals(new int[] {7, 8, 9, 12}, v);
		
		v = new int[] {9,7,12,7};
		Array.sort(v);
		assertArrayEquals(new int[] {7, 7, 9, 12}, v);
	}
}
