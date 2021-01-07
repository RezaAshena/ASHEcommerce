import { IProduct } from './product';

export interface IPagination {
  pageIndex: number;
  PageSize: number;
  count: number;
  data: IProduct[];

}
