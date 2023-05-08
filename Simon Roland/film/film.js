    import java.io.*;
    import javax.servlet.*;
import javax.servlet.http.*;

public class ColorChooserServlet extends HttpServlet {
  public void doPost(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {

    // get the color input from the user
    String colorInput = request.getParameter("color");

    // set the background color of the HTML page to the user's chosen color
    response.setContentType("text/html");
    PrintWriter out = response.getWriter();
    out.println("<html>");
    out.println("<head>");
    out.println("<title>Color Chooser Result</title>");
    out.println("<style>");
    out.println("body { background-color: " + colorInput + "; }");
    out.println("</style>");
    out.println("</head>");
    out.println("<body>");
    out.println("<h1>Your chosen color is " + colorInput + "</h1>");
    out.println("</body>");
    out.println("</html>");
  }
}
