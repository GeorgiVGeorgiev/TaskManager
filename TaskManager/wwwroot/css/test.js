
var TypeProjectCountData = [{"type":"\u0413\u0435\u043E\u0434\u0435\u0437\u0438\u0447\u0435\u0441\u043A\u043E \u0437\u0430\u0441\u043D\u0435\u043C\u0430\u043D\u0435","projectCount":6},{"type":"\u0422\u0440\u0430\u0441\u0438\u0440\u043E\u0432\u043A\u0430","projectCount":0},{"type":"\u0412\u0435\u0440\u0442\u0438\u043A\u0430\u043B\u043D\u043E \u043F\u043B\u0430\u043D\u0438\u0440\u0430\u043D\u0435","projectCount":1},{"type":"\u041A\u043E\u043C\u0431\u0438\u043D\u0438\u0440\u0430\u043D\u0430 \u0441\u043A\u0438\u0446\u0430","projectCount":0},{"type":"\u0418\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0435 \u043D\u0430 \u043F\u043B\u0430\u043D \u0437\u0430 \u0440\u0435\u0433\u0443\u043B\u0430\u0446\u0438\u044F","projectCount":1},{"type":"\u0417\u0430\u0441\u043D\u0435\u0430\u043C\u043D\u0435 \u0437\u0430 \u043F\u043B\u043E\u0449","projectCount":0},{"type":"\u0417\u0430\u0441\u043D\u0435\u043C\u0430\u043D\u0435 \u043F\u043E \u0447\u043B.19 \u043E\u0442 \u0417\u0423\u0417\u0421\u041E","projectCount":0},{"type":"\u0422\u0440\u0430\u0441\u0438\u0440\u0430\u043D\u0435 \u043D\u0430 \u043E\u0441\u0438 \u043E\u0442 \u043C\u0435\u0440\u0430\u0447","projectCount":0},{"type":"\u0413\u0435\u043E\u0440\u0433\u0438 \u0413\u0435\u043E\u0440\u0433\u0438\u0435\u0432","projectCount":0}];

 {
  var PieData = {
      series: [TypeProjectCountData.map(function (item) { return item.projectCount })],
      labels: [TypeProjectCountData.map(function (item) { return item.type })]
  };

  var PieOptions = {
      series: PieData.series,
      chart: {
          width: '100%',
          type: 'pie',
      },
      labels: PieData.labels,
      theme: {
          monochrome: {
              enabled: true
          }
      },
      plotOptions: {
          pie: {
              dataLabels: {
                  offset: -5
              }
          }
      },
      title: {
          text: "Monochrome Pie"
      },
      dataLabels: {
          formatter(val, opts) {
              const name = opts.w.globals.labels[opts.seriesIndex]
              return [name, val.toFixed(1) + '%']
          }
      },
      legend: {
          show: false
      }
  };
  return PieOptions;
}