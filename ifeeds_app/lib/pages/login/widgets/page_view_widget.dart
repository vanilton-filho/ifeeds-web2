import 'dart:async';

import 'package:flutter/material.dart';
import 'package:ifeeds_app/pages/login/widgets/page_image_widget.dart';

class PageViewWidget extends StatefulWidget {
  final int totalPages;
  final List<PageImageWidget> images;

  const PageViewWidget({
    Key? key,
    required this.totalPages,
    required this.images,
  }) : super(key: key);

  @override
  _PageViewWidgetState createState() => _PageViewWidgetState();
}

class _PageViewWidgetState extends State<PageViewWidget> {
  int _currentPage = 0;
  PageController? _pageController;

  @override
  void initState() {
    super.initState();

    _pageController = PageController(initialPage: 0, keepPage: true);

    Timer.periodic(Duration(seconds: 5), (Timer timer) {
      if (_currentPage < widget.totalPages - 1) {
        _currentPage++;
      } else {
        _currentPage = 0;
      }
      if (_pageController!.hasClients) {
        _pageController!.animateToPage(
          _currentPage,
          duration: Duration(milliseconds: 350),
          curve: Curves.easeIn,
        );
      }
    });
  }

  @override
  void dispose() {
    _pageController!.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return PageView(
      controller: _pageController,
      children: [...widget.images],
    );
  }
}
