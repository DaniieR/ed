package org.institutoserpis.ed;

public class Array {

	public static void main(String[] args) {

		int[] v = new int[]{5, 9, 7, 12, 21};
		
		for (int index=0; index < v.length; index++)
			System.out.println("elemento con index=" + index + " vale " + v[index]);
		
		System.out.println("suma del array=" + suma(v));
		System.out.println("suma de otro array=" + suma(new int[]{14, 24}));
		System.out.println("suma array vacio=" + suma(new int[]{}));
		
		System.out.println("el valor menor en v es: " + menor(v));
		System.out.println("el índice de 12 en v es: " + indexOf(v, 12));
		
	}
	
	public static int suma(int[] v) {
		// número de elementos del vector: v.length
		int suma = 0;
		
//		for (int index=0; index < v.length; index++)
//			suma = suma + v[index];
		
		for (int item : v)
			suma = suma + item;
		
		return suma;
	}
	
	public static int menor(int[] v) {
//		int menor = v[0];
//		for (int index = 1; index < v.length; index++)
//			if (v[index] < menor)
//				menor = v[index];
//		return menor;
			int posMenor = 0;
			for (int index = 1; index < v.length; index++)
				if (v[index] < v[posMenor])
					posMenor = index;
			return v[posMenor];
		}
	
	public static int indexOf(int[] v, int item) {
		for (int index =0; index < v.length; index++){
			if (v[index] == item){
				return index;
			}
		}
		return -1;
	}
	public static void sort(int[] v){
		for (int stepIndex = 0; stepIndex < v.length -1; stepIndex++){
			int minIndex = stepIndex ;
			for (int index = stepIndex + 1; index < v.length; index++){
				if (v[index] < v[minIndex])
					minIndex = index;
			int aux = v[stepIndex];
			v[stepIndex] = v[minIndex];
			v[minIndex] = aux;
			}
		}
	}

}
