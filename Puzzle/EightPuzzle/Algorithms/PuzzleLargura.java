//
// Pontifícia Universidade Católica de Minas Gerais
// Unidade São Gabriel
// Disciplina: Algoritmos e Estrutura de Dados
// *Algorithms and Data Structures
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
package Algorithms;

import java.util.HashMap;
import java.util.LinkedList;
import java.util.Map;
import java.util.Queue;

public class PuzzleLargura {

	// Estado final (Solução).
	private final String ESTADO_FINAL = "123456780";

	// Utiliza a Fila, cuja implementada utilizando a Lista Encadeada
	// (LinkedList) para Armazenar Todos os Nós na Busca em Largura.
	Queue<String> agenda = new LinkedList<String>();

	// HashMap é utilizada para ignorar os nós repetidos. Refere-se cada um a
	// sua posição antecessora.
	Map<String, Integer> profundidadesDeEstados = new HashMap<String, Integer>();

	Map<String, String> historicoDeEstados = new HashMap<String, String>();

	public static void main(String args[]) {

		// Preenche o Tabuleiro de Estados como uma String, sendo "0", o Espaço
		// em Branco.
		String stringInicial = "087465132";

		// Nova instância do PuzzleLargura.
		PuzzleLargura solucionador = new PuzzleLargura();

		// Adiciona o Estado Inicial.
		solucionador.add(stringInicial, null);

		while (!solucionador.agenda.isEmpty()) {
			String estadoAtual = solucionador.agenda.remove();
			// Move o Espaço em Branco para CIMA e adiciona o novo estado a
			// fila.
			solucionador.paraCima(estadoAtual);
			// Move o Espaço em Branco para BAIXO.
			solucionador.paraBaixo(estadoAtual);
			// Move o Espaço em Branco para ESQUERDA.
			solucionador.paraEsquerda(estadoAtual);
			// Move o Espaço em Branco para DIREITA e remove o Nó Atual da fila.
			solucionador.paraDireita(estadoAtual);
		}
		System.out.println("Solução não existe.");
	}

	// Método para adicionar a nova String para o Map (Mapa) e a Queue (Fila).
	void add(String estadoNovo, String estadoVelho) {
		if (!profundidadesDeEstados.containsKey(estadoNovo)) {
			int novoValor = estadoVelho == null ? 0 : profundidadesDeEstados.get(estadoVelho) + 1;
			profundidadesDeEstados.put(estadoNovo, novoValor);
			agenda.add(estadoNovo);
			historicoDeEstados.put(estadoNovo, estadoVelho);
		}
	}

	/*
	 * Cada um dos métodos abaixo Toma o Estado Atual do Tabuleiro como String.
	 * Em seguida, a operação para mover o Espaço em Branco é feita, se
	 * possível. Depois que a nova String é adicionada ao Map (Mapa) e a Queue
	 * (Fila). Se é o Estado Objetivo, então o programa termina.
	 */
	void paraCima(String estadoAtual) {
		int a = estadoAtual.indexOf("0");
		if (a > 2) {
			String proximoEstado = estadoAtual.substring(0, a - 3) + "0" + estadoAtual.substring(a - 2, a)
					+ estadoAtual.charAt(a - 3) + estadoAtual.substring(a + 1);
			verificaConclusao(estadoAtual, proximoEstado);
		}
	}

	void paraBaixo(String estadoAtual) {
		int a = estadoAtual.indexOf("0");
		if (a < 6) {
			String proximoEstado = estadoAtual.substring(0, a) + estadoAtual.substring(a + 3, a + 4)
					+ estadoAtual.substring(a + 1, a + 3) + "0" + estadoAtual.substring(a + 4);
			verificaConclusao(estadoAtual, proximoEstado);
		}
	}

	void paraEsquerda(String estadoAtual) {
		int a = estadoAtual.indexOf("0");
		if (a != 0 && a != 3 && a != 6) {
			String proximoEstado = estadoAtual.substring(0, a - 1) + "0" + estadoAtual.charAt(a - 1)
					+ estadoAtual.substring(a + 1);
			verificaConclusao(estadoAtual, proximoEstado);
		}
	}

	void paraDireita(String estadoAtual) {
		int a = estadoAtual.indexOf("0");
		if (a != 2 && a != 5 && a != 8) {
			String proximoEstado = estadoAtual.substring(0, a) + estadoAtual.charAt(a + 1) + "0"
					+ estadoAtual.substring(a + 2);
			verificaConclusao(estadoAtual, proximoEstado);
		}
	}

	private void verificaConclusao(String estadoVelho, String estadoNovo) {
		add(estadoNovo, estadoVelho);

		if (estadoNovo.equals(ESTADO_FINAL)) {

			System.out.println("Soluçao existe no Nível " + profundidadesDeEstados.get(estadoNovo) + " da arvore.");
			ImprimirPassosAteSolucao(estadoNovo);

			// Encerra programa.
			System.exit(0);
		}
	}

	private void ImprimirPassosAteSolucao(String estadoFinal) {
		String tracarEstado = estadoFinal;
		while (tracarEstado != null) {
			System.out.println(tracarEstado + " no movimento " + profundidadesDeEstados.get(tracarEstado));
			tracarEstado = historicoDeEstados.get(tracarEstado);
		}
	}
}
