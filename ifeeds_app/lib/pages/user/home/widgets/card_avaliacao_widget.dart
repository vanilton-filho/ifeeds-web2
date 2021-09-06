import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_colors.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/pages/user/formulario/formulario_avaliacao_page.dart';

class CardAvaliacaoWidget extends StatefulWidget {
  final AvaliacaoModel avaliacaoModel;

  const CardAvaliacaoWidget({
    Key? key,
    required this.avaliacaoModel,
  }) : super(key: key);

  @override
  _CardAvaliacaoWidgetState createState() => _CardAvaliacaoWidgetState();
}

class _CardAvaliacaoWidgetState extends State<CardAvaliacaoWidget> {
  @override
  Widget build(BuildContext context) {
    return Card(
      elevation: 3,
      child: Container(
        decoration: BoxDecoration(
          border: Border(
            top: BorderSide(width: 8.0, color: Colors.blueGrey),
          ),
        ),
        child: InkWell(
          hoverColor: AppColors.primarySwatch[50],
          onLongPress: () => _showModal(),
          onTap: () => Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => FormularioAvaliacaoPage(
                        avaliacaoModel: widget.avaliacaoModel,
                      ))),
          child: Padding(
            padding: const EdgeInsets.all(8.0),
            child: Container(
              width: 300,
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  // Padding(
                  //   padding: EdgeInsets.all(3.0),
                  //   child: Container(
                  //     color: Colors.blue,
                  //     height: 100, // altura da img ou icon
                  //   ),
                  // ),
                  Expanded(
                    child: Padding(
                      padding: EdgeInsets.all(3.0),
                      child: Row(
                        children: [
                          Expanded(
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              children: [
                                Padding(
                                  padding: const EdgeInsets.all(5.0),
                                  child: Text(
                                    widget.avaliacaoModel.titulo!,
                                    style: AppTextStyles.categoria2,
                                  ),
                                ),
                              ],
                            ),
                          ),
                          Align(
                            alignment: Alignment.topCenter,
                            child: Column(
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: [
                                IconTheme(
                                  data: IconThemeData(
                                    color: Colors.amber,
                                    size: 25,
                                  ),
                                  child: Icon(
                                    Icons.star_rounded,
                                  ),
                                ),
                                Text(
                                  '${widget.avaliacaoModel.mediaAvaliacao!.toStringAsFixed(1)}',
                                  style: GoogleFonts.robotoMono(
                                    fontSize: 14,
                                    fontWeight: FontWeight.w300,
                                  ),
                                ),
                              ],
                            ),
                          ),
                        ],
                      ),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.only(left: 10.0, bottom: 5),
                    child: Text(widget.avaliacaoModel.campus!.nome!),
                  )
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }

  _showModal() async {
    await showModalBottomSheet(
        isDismissible: true,
        isScrollControlled: true,
        context: context,
        builder: (context) {
          return Container(
            height: 200,
            child: Padding(
              padding: const EdgeInsets.only(top: 12.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.center,
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        Padding(
                          padding: const EdgeInsets.all(12.0),
                          child: Text(
                            '${widget.avaliacaoModel.titulo}',
                            style: AppTextStyles.normal,
                          ),
                        ),
                        IntrinsicHeight(
                          child: Row(
                            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                            crossAxisAlignment: CrossAxisAlignment.center,
                            children: [
                              Expanded(
                                child: Column(
                                  children: [
                                    Padding(
                                      padding: const EdgeInsets.all(8.0),
                                      child: Text(
                                        'Total de feedbacks',
                                        style: GoogleFonts.roboto(
                                            fontSize: 24.0,
                                            fontWeight: FontWeight.w500),
                                        textAlign: TextAlign.center,
                                      ),
                                    ),
                                    Text(
                                      '${widget.avaliacaoModel.totalFeedbacks}',
                                      style: GoogleFonts.roboto(
                                          fontSize: 42.0,
                                          fontWeight: FontWeight.bold),
                                      textAlign: TextAlign.center,
                                    ),
                                  ],
                                ),
                              ),
                              VerticalDivider(
                                color: Colors.grey,
                                thickness: 1,
                              ),
                              Expanded(
                                child: Row(
                                  mainAxisAlignment: MainAxisAlignment.center,
                                  children: [
                                    Text(
                                      '${widget.avaliacaoModel.mediaAvaliacao!.toStringAsFixed(1)}',
                                      style: GoogleFonts.roboto(
                                          fontSize: 42.0,
                                          fontWeight: FontWeight.bold),
                                    ),
                                    IconTheme(
                                      data: IconThemeData(
                                        color: Colors.amber,
                                      ),
                                      child: Icon(
                                        Icons.star_rounded,
                                      ),
                                    ),
                                    Padding(
                                      padding: const EdgeInsets.all(8.0),
                                      child: Text(
                                        'de Média',
                                        style: GoogleFonts.roboto(
                                            fontSize: 24.0,
                                            fontWeight: FontWeight.w500),
                                        textAlign: TextAlign.center,
                                      ),
                                    ),
                                  ],
                                ),
                              ),
                            ],
                          ),
                        )
                      ],
                    ),
                  ),
                ],
              ),
            ),
          );
        },
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.only(
              topLeft: Radius.circular(42.0), topRight: Radius.circular(42.0)),
        ));
  }
}
