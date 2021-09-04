
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/models/estatistica_model.dart';
import 'package:ifeeds_app/pages/user/admin/widgets/card_gridview_widget.dart';
import 'package:ifeeds_app/pages/widgets/error_app_widget.dart';
import 'package:ifeeds_app/pages/widgets/router_login.dart';
import 'package:ifeeds_app/services/estatistica_service.dart';

class HomeAdminPage extends StatefulWidget {
  const HomeAdminPage({Key? key}) : super(key: key);

  @override
  _HomeAdminPageState createState() => _HomeAdminPageState();
}

class _HomeAdminPageState extends State<HomeAdminPage> {
  var estatisticaModel = EstatisticaModel();

  @override
  Widget build(BuildContext context) {
    var widthSize = MediaQuery.of(context).size.width;
    return StreamBuilder(
        stream: estatisticasStream(),
        builder: (context, AsyncSnapshot<dynamic> snapshot) {
          if (snapshot.hasData) {
            EstatisticaModel estatisticas = snapshot.data!;
            return GridView.count(
              crossAxisCount: 2,
              crossAxisSpacing: 10,
              mainAxisSpacing: 5,
              childAspectRatio: widthSize > 930 ? (0.8 / 0.2) : 1,
              padding: EdgeInsets.all(8.0),
              children: [
                CardGridView(
                  color: Colors.red,
                  value: estatisticas.feedbacksSemResposta,
                  label: 'Feedbacks sem respostas',
                ),
                CardGridView(
                  color: Colors.green,
                  value: estatisticas.feedbacksRespondidos,
                  label: 'Feedbacks respondidos',
                ),
                InkWell(
                  onLongPress: () => Navigator.push(context, MaterialPageRoute(
                    builder: (context) => Scaffold(
                    body: Center(
                      child: Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          Icon(Icons.favorite, color: Colors.redAccent, size: 90,),
                          Text("Satisfeitos ficaríamos com a nota 10!!! ;-)", style: GoogleFonts.roboto(fontSize: 42),),
                        ],  
                      ),
                    ),
                  )),),
                  child: CardGridView(
                    color: Colors.purple,
                    value: estatisticas.satisfacaoGeral,
                    label: 'Satisfação',
                  ),
                ),
                CardGridView(
                  color: Colors.blue,
                  value: estatisticas.quantidadeFeedbacks,
                  label: 'Feedbacks',
                ),
              ],
            );
          } else if (snapshot.hasError) {
            return ErrorAppWidget(message: '${snapshot.error}');
          }
          return Center(
            child: Row(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                CircularProgressIndicator(),
              ],
            ),
          );
        });
  }

  estatisticasStream() async* {
    while (true) {
      await Future.delayed(Duration(milliseconds: 5000));
      var estatisticas =
          await EstatisticaService().getEstatisticas(1);
      if(estatisticas == true){
        RouterLogin.routeToLogin(context);
        break;
      }
      yield estatisticas;
    }
  }
}
