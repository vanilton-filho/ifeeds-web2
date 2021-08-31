import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/feedback_model.dart';
import 'package:intl/intl.dart';

class TileWidget extends StatefulWidget {
  final double? marginRight;
  final FeedbackModel feedbackModel;

  const TileWidget({
    Key? key,
    this.marginRight,
    required this.feedbackModel,
  }) : super(key: key);

  @override
  _TileWidgetState createState() => _TileWidgetState();
}

class _TileWidgetState extends State<TileWidget> {
  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 12.0, vertical: 4.0),
      child: Padding(
        padding: const EdgeInsets.symmetric(vertical: 3),
        child: Container(
          child: InkWell(
            onTap: () => _showModal(),
            child: ClipPath(
              clipper: ShapeBorderClipper(
                  shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.only(
                          topLeft: Radius.circular(15),
                          bottomLeft: Radius.circular(15)))),
              child: Container(
                  height: 180,
                  decoration: BoxDecoration(
                    border: Border(
                      left: BorderSide(color: Colors.blueGrey, width: 24),
                    ),
                  ),
                  padding: EdgeInsets.all(20.0),
                  alignment: Alignment.centerLeft,
                  child: Container(
                    child: Row(
                      children: [
                        Expanded(
                            flex: 3,
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: [
                                Padding(
                                  padding: const EdgeInsets.only(bottom: 14.0),
                                  child: Text(
                                    '${widget.feedbackModel.titulo}',
                                    style: AppTextStyles.normal2.merge(
                                        TextStyle(
                                            fontWeight: FontWeight.bold,
                                            fontSize: 20)),
                                  ),
                                ),
                                widget.feedbackModel.status!
                                    ? Wrap(children: [
                                        Padding(
                                          padding:
                                              const EdgeInsets.only(right: 3),
                                          child: Icon(
                                            Icons.check_circle,
                                            color: Colors.green,
                                          ),
                                        ),
                                        Text(
                                            'Respondido em: ${DateFormat('dd-MM-yyyy').format(widget.feedbackModel.dataResposta!)}'),
                                      ])
                                    : Wrap(
                                        children: [
                                          Padding(
                                            padding:
                                                const EdgeInsets.only(right: 3),
                                            child: Icon(
                                              Icons.check_circle,
                                              color: Colors.grey,
                                            ),
                                          ),
                                          Text('Não Respondido'),
                                        ],
                                      ),
                              ],
                            )),
                        Expanded(
                          flex: 2,
                          child: Padding(
                            padding:
                                const EdgeInsets.symmetric(horizontal: 12.0),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.end,
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: [
                                Padding(
                                  padding: const EdgeInsets.only(bottom: 15.0),
                                  child: Row(
                                    mainAxisAlignment: MainAxisAlignment.end,
                                    crossAxisAlignment:
                                        CrossAxisAlignment.center,
                                    children: [
                                      Padding(
                                        padding: const EdgeInsets.all(8.0),
                                        child: Icon(
                                          Icons.star,
                                          color: Colors.amber,
                                        ),
                                      ),
                                      Text(
                                        '${widget.feedbackModel.nota!.toStringAsFixed(1)}',
                                        style: AppTextStyles.normal2.merge(
                                          TextStyle(
                                            fontSize: 27,
                                          ),
                                        ),
                                      )
                                    ],
                                  ),
                                ),
                                Text(
                                    '${DateFormat('dd-MM-yyyy').format(widget.feedbackModel.dataCriacao!)}',
                                    style: AppTextStyles.normal2
                                        .merge(TextStyle(fontSize: 16))),
                              ],
                            ),
                          ),
                        ),
                      ],
                    ),
                  )),
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
            height: 600,
            child: Padding(
              padding: const EdgeInsets.only(top: 50.0),
              child: SingleChildScrollView(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: [
                    Padding(
                      padding: const EdgeInsets.all(8.0),
                      child: RatingBar.builder(
                        itemSize: 42,
                        initialRating: widget.feedbackModel.nota!,
                        direction: Axis.horizontal,
                        allowHalfRating: true,
                        itemCount: 5,
                        itemPadding: EdgeInsets.symmetric(horizontal: 4.0),
                        itemBuilder: (context, _) => Icon(
                          Icons.star_rounded,
                          color: Colors.amber,
                        ),
                        ignoreGestures: true,
                        onRatingUpdate: (_) => {},
                      ),
                    ),
                    Text(
                      '${widget.feedbackModel.nota!.toStringAsFixed(1)}',
                      style: GoogleFonts.robotoCondensed(
                        fontSize: 23.0,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.all(16.0),
                      child: Wrap(
                        children: [
                          Text(
                            '${widget.feedbackModel.descricao}',
                            style: GoogleFonts.roboto(fontSize: 21.0),
                            textAlign: TextAlign.center,
                          ),
                        ],
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.only(top: 12.0),
                      child: Text(
                        '${widget.feedbackModel.campus}',
                        style: GoogleFonts.roboto(),
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.all(12.0),
                      child: Column(
                        children: [
                          Padding(
                            padding: const EdgeInsets.all(3.0),
                            child: Text(
                              'Data de criação ${DateFormat('dd-MM-yyyy').format(widget.feedbackModel.dataCriacao!)}',
                              style: GoogleFonts.roboto(color: Colors.grey),
                            ),
                          ),
                          Text(
                            'Código ${widget.feedbackModel.codigo}',
                            style: GoogleFonts.roboto(color: Colors.grey),
                          ),
                        ],
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.symmetric(horizontal: 27.0),
                      child: Divider(
                        thickness: 1,
                      ),
                    ),
                    Padding(
                        padding: const EdgeInsets.only(top: 23.0),
                        child: Text(
                          'Resposta',
                          style: GoogleFonts.roboto(fontSize: 20.0),
                        )),
                    Padding(
                      padding: const EdgeInsets.all(12.0),
                      child: widget.feedbackModel.resposta == null
                          ? Text(
                              'Nenhuma resposta até o momento...',
                              style: GoogleFonts.roboto(
                                  fontSize: 14.0, color: Colors.grey),
                            )
                          : Text(
                              '${widget.feedbackModel.resposta}',
                              style: GoogleFonts.roboto(
                                fontSize: 14.0,
                              ),
                            ),
                    ),
                  ],
                ),
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
