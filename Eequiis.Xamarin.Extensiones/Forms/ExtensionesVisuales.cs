using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eequiis.Xamarin.Extensiones
{
	public static class ExtensionesVisuales
	{
		private static readonly string MensajeInfoNulo = "(Sin mensaje de información)";
		private static readonly string MensajeErrorNulo = "(Sin mensaje de error)";
			

		/// <summary>
		/// <para>Muestra un cuadro de diálogo informativo, con el mensaje indicado y una opción de aceptar.</para>
		/// <para>La página suministrada, que lanzará el cuadro de diálogo, no puede ser nula; mientras que el mensaje
		/// indicado sí podrá serlo, en cuyo caso el mensaje mostrado en el cuadro de diálogo informará de que no hay
		/// un cuerpo real de mensaje informativo.</para>
		/// <para>Excepciones:</para>
		/// <list type="bullet">
		/// <item><see cref="NullReferenceException"/>Si la página indicada es nula.</item>
		/// </list>
		/// </summary>
		/// <param name="pagina">Página que lanzará el cuadro de diálogo.</param>
		/// <param name="mensaje">Mensaje informativo a mostrar en el cuadro de diálogo.</param>
		public static Task MostrarInfo(this Page pagina, string mensaje)
			=> pagina.DisplayAlert("Información", mensaje ?? MensajeInfoNulo, "Aceptar");

		/// <summary>
		/// <para>Muestra un cuadro de diálogo de error, con el mensaje indicado y una opción de aceptar.</para>
		/// <para>La página suministrada, que lanzará el cuadro de diálogo, no puede ser nula; mientras que el mensaje
		/// indicado sí podrá serlo, en cuyo caso el mensaje mostrado en el cuadro de diálogo informará de que no hay
		/// un cuerpo real de mensaje de error.</para>
		/// <para>Excepciones:</para>
		/// <list type="bullet">
		/// <item><see cref="NullReferenceException"/> - Si la página indicada es nula.</item>
		/// </list>
		/// </summary>
		/// <param name="pagina">Página que lanzará el cuadro de diálogo.</param>
		/// <param name="mensaje">Mensaje de error a mostrar en el cuadro de diálogo.</param>
		public static Task MostrarError(this Page pagina, string mensaje)
			=> pagina.DisplayAlert("Error", mensaje ?? MensajeErrorNulo, "Aceptar");

		/// <summary>
		/// <para>Selecciona todo el texto de un elemento visual <see cref="Entry"/>.</para>
		/// <para>El campo de texto indicado no puede ser nulo, y si contiene texto, este se seleccionará.</para>
		/// <para>Excepciones:</para>
		/// <list type="bullet">
		/// <item><see cref="NullReferenceException"/> - Si el campo de texto indicado es nulo.</item>
		/// </list>
		/// </summary>
		/// <param name="entrada">Campo de texto cuyo texto se seleccionará.</param>
		public static void SelectAllText(this Entry entrada)
		{
			if (entrada.Text == null) return;
			entrada.CursorPosition = 0;
			entrada.SelectionLength = entrada.Text.Length;
		}
	}
}
